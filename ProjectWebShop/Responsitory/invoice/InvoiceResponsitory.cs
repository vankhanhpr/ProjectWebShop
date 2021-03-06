﻿using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Interface.invoice;
using ProjectWebShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMyShop.Data;

namespace ProjectWebShop.Responsitory.invoice
{
    public class InvoiceResponsitory : Responsitory<Invoices>, IInvoiceResponsitory
    {
        private DbSet<Invoices> envoiceEntity;

        public InvoiceResponsitory(MyDBContext context) : base(context)
        {
            envoiceEntity = context.Set<Invoices>();
        }

        public dynamic FilterBySearchBox(string dtfilter)
        {
            var filterby = dtfilter.Trim().ToLowerInvariant();
   
            var invoice = context.Invoices.Select(invoi => new
            {
                invoi,
                invoiceproduct = from invoidprd in context.InvoiceProduct
                                 where invoi.ivid == invoidprd.ivid
                                 join product in context.Products
                                 on invoidprd.prid equals product.prid
                                 select new { invoidprd, product }
            }).ToList().AsQueryable().Where(m => m.invoi.codeinvoice.ToLowerInvariant().Contains(filterby)
                                || m.invoi.namecustomer.ToLowerInvariant().Contains(filterby)
                                //|| m.invoi.adressdelviver.ToLowerInvariant().Contains(filterby)
                                //|| m.invoi.ivid.ToString().ToLowerInvariant().Contains(filterby)
                                || m.invoi.phonenumber.ToLowerInvariant().Contains(filterby)
                                //|| m.invoi.email.ToLowerInvariant().Contains(filterby)
                                //|| m.invoi.province.ToLowerInvariant().Contains(filterby)
                                //|| m.invoi.adress.ToLowerInvariant().Contains(filterby)
                                //|| m.invoi.codediscount.ToLowerInvariant().Contains(filterby)
                                //|| m.invoi.usid.ToString().ToLowerInvariant().Contains(filterby)
                                //|| m.invoi.codediscount.ToLowerInvariant().Contains(filterby)
                               );
            return invoice;
        }

        public dynamic FilterInvoiceByDay(DateTime std, DateTime eday)
        {
            var invoice = context.Invoices.Where(x => x.createday >=std && x.createday<=eday ).Select(invoi => new
            {
                invoi,
                invoiceproduct = from invoidprd in context.InvoiceProduct
                                 where invoi.ivid == invoidprd.ivid
                                 join product in context.Products
                                 on invoidprd.prid equals product.prid
                                 select new { invoidprd, product }
            }).ToList();
            return invoice;
        }

        //get invoid insert new (socket.io)
        public dynamic GetFirstInvoice(string code)
        {
            var invoice = context.Invoices.Where(x=>x.codeinvoice==code).Select(invoi => new
            {
                invoi,
                invoiceproduct = from invoidprd in context.InvoiceProduct
                                 where invoi.ivid== invoidprd.ivid
                                 join product in context.Products
                                 on invoidprd.prid equals product.prid
                                 select new { invoidprd, product }
            }).FirstOrDefault();
            return invoice;
        }

        //get by id
        public dynamic GetInvoiceById(int ivid)
        {
            var invoice = context.Invoices.Where(x => x.ivid == ivid).Select(invoi => new
            {
                invoi,
                invoiceproduct = context.InvoiceProduct.Where(y=>y.ivid==invoi.ivid)
            }).FirstOrDefault();
            return invoice;
        }

        public dynamic GetInvoiceByUser(int usid)
        {
            var item = context.Invoices.Where(x => x.usid == usid).Select(invoice => new
            {
                invoice,
                invoiceproduct = context.InvoiceProduct.Where(ivprd => ivprd.ivid == invoice.ivid).ToList()
            }).FirstOrDefault();
            return item;
        }

        public Invoices GetInvoid(int inv)
        {
            return context.Invoices.Where(x => x.ivid == inv).FirstOrDefault();
        }

        //get invoice by active
        public dynamic GetNewInvoiceActive(int active,int page,int pagesize)
        {
            var invoice = context.Invoices.Where(x => x.status == active).Select(invoi => new
            {
                invoi,
                invoiceproduct = from invoidprd in context.InvoiceProduct
                                 where invoi.ivid == invoidprd.ivid
                                 join product in context.Products
                                 on invoidprd.prid equals product.prid
                                 select new { invoidprd, product }
            }).ToList().Skip(page*pagesize).Take(pagesize);             
            return invoice;
        }

        //insert invoice product
        public void InsertInvoiceProduct(InvoiceProduct invoiceProduct)
        {
            context.Entry(invoiceProduct).State = EntityState.Added;
            context.SaveChanges();
        }
        //insert invoice
        public Invoices InsetInvoice(Invoices invoice)
        {
            context.Entry(invoice).State = EntityState.Added;
            context.SaveChanges();
            return invoice;
        }

        public void UpdateInvoice(Invoices inv)
        {
            context.Update(inv);
            context.SaveChanges();
        }
    }
}

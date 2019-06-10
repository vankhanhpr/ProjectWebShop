using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Interface.invoice;
using ProjectWebShop.Model;
using System;
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

    }
}

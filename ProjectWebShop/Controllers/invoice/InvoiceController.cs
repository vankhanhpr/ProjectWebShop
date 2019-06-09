using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.invoice;
using ProjectWebShop.Model;

namespace ProjectWebShop.Controllers.invoice
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : Controller
    {
        private IInvoiceResponsitory m_invoiceResponcitory;
       public InvoiceController(IInvoiceResponsitory invoiceResponcitory)
        {
            m_invoiceResponcitory = invoiceResponcitory;
        }
        [HttpPost("InsertInvoive")]
        public DataRespont InsertInvoive([FromForm] InvoiceRequest invoice)
        {
            DataRespont data = new DataRespont();
            try
            {
                Invoices inv = new Invoices();
                inv.namecustomer = invoice.namecustomer;
                inv.gender = invoice.gender;
                inv.phonenumber = invoice.phonenumber;
                inv.email = invoice.email;
                inv.province = invoice.province;
                inv.district = invoice.district;
                inv.adress = invoice.adress;
                inv.adressdelviver = invoice.adressdelviver;
                inv.timedeliver = invoice.timedeliver;
                inv.typepay = invoice.typepay;
                inv.totalmoney = invoice.totalmoney;
                inv.money = invoice.money;
                inv.codediscount = invoice.codediscount;
                inv.note = invoice.note;
                inv.usid = invoice.usid;

                m_invoiceResponcitory.InsetInvoice(inv);

                foreach(var i in invoice.invoiceproduct)
                {
                    //InvoiceProduct invprd = new InvoiceProduct(i);
                   // m_invoiceResponcitory.InsertInvoiceProduct(invprd);
                }
                data.success = true;
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }
    }
}
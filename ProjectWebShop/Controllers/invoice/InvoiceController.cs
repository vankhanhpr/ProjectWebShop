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
        //insert invoice
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
                inv.codeinvoice = RandomString(20);
                Invoices newinv= m_invoiceResponcitory.InsetInvoice(inv);

                foreach (var i in invoice.invoiceproduct)
                {
                    InvoiceProductRequest invprd = new InvoiceProductRequest(i);
                    InvoiceProduct invoicers = new InvoiceProduct();
                    invoicers.prid = invprd.prid;
                    invoicers.total = invprd.total;
                    invoicers.ivid = newinv.ivid;
                    m_invoiceResponcitory.InsertInvoiceProduct(invoicers);
                }
                data.success = true;
                data.data = newinv;
            }
            catch (Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }
        //get invoice by id
        [HttpGet("GetInvoicebyId")]
        public DataRespont GetInvoicebyId(int id)
        {
            DataRespont data = new DataRespont();
            try
            {
                data.success = true;
                data.data = m_invoiceResponcitory.GetInvoiceById(id);
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }
        //random code invoice 
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghiklmnopqrstwz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
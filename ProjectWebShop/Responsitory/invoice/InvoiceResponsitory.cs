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
        public dynamic getInvoiceByUser(int usid)
        {
            var item = context.Invoices.Where(x => x.usid == usid).Select(invoice => new
            {
                invoice,
                invoiceproduct = context.InvoiceProduct.Where(ivprd => ivprd.prid == invoice.prid).ToList()
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
        public void InsetInvoice(Invoices invoice)
        {
            context.Entry(invoice).State = EntityState.Added;
            context.SaveChanges();
        }
    }
}

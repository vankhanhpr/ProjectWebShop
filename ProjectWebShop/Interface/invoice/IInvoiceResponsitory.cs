using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Interface.invoice
{
    public interface IInvoiceResponsitory: IResponsitory<Invoices>
    {
        Invoices InsetInvoice(Invoices invoice);
        dynamic GetInvoiceByUser(int usid);
        dynamic GetInvoiceById(int ivid);
        void InsertInvoiceProduct(InvoiceProduct invoiceProduct);
    }
}

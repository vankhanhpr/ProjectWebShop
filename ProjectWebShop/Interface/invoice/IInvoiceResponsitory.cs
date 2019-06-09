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
        void InsetInvoice(Invoices invoice);
        dynamic getInvoiceByUser(int usid);
        void InsertInvoiceProduct(InvoiceProduct invoiceProduct);
    }
}

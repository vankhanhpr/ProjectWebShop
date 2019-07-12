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
        dynamic GetNewInvoiceActive(int active);
        dynamic GetFirstInvoice(string code);
        void UpdateInvoice(Invoices inv);
        Invoices GetInvoid(int inv);
        dynamic FilterInvoiceByDay(DateTime std,DateTime eday);

    }
}

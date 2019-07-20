using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model.discount;
using System.Collections.Generic;

namespace ProjectWebShop.Interface.product
{
    public interface IDiscountResponsitory : IResponsitory<Discount>
    {
        IEnumerable< Discount>  GetAllDiscount(int page, int pagesize);
        Discount GetDisCountByCode(string code);
        void CreateEvent(Discount ds);
        void EnableEvent(Discount ds);
        void EditDiscount(Discount ds);
        void DeleteDiscount(string code);
        IEnumerable<Discount> FilterDiscount(string filter);
    }
}

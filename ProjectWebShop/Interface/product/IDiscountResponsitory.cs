using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model.discount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Interface.product
{
    public interface IDiscountResponsitory : IResponsitory<Discount>
    {
        IEnumerable< Discount>  GetAllDiscount();
        Discount GetDisCountByCode(string code);
        void CreateEvent(Discount ds);
        void EnableEvent(Discount ds);
        void EditDiscount(Discount ds);
        void DeleteDiscount(string code);
    }
}

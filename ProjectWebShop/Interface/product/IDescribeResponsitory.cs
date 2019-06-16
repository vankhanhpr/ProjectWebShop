using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Interface.product
{
    public interface IDescribeResponsitory : IResponsitory<Describeproducts>
    {
        dynamic getDescriptPrById(int prid);
        dynamic getAllDescript();
        void inserDes(Describeproducts des);
        void delateDes(Describeproducts des);
        void updateDes(Describeproducts des);
    }
}

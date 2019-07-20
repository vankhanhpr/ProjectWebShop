using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model.complain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Interface.compalin
{
    public interface IComplainResponsitory:IResponsitory<Complain>
    {
        dynamic GetAllComplain(int page, int pagesize);
        void InsertComplain(Complain complain);
    }
}

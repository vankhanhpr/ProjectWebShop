using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model.units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Interface.unit
{
    public interface IProvinceResponsitory : IResponsitory<Devvn_tinhthanhpho>
    {
        dynamic getAllProvince();
    }
}

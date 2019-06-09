using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Interface.unit;
using ProjectWebShop.Model.units;
using System;
using System.Linq;
using WebApiMyShop.Data;

namespace ProjectWebShop.Responsitory.unit
{
    public class DistrictResponsitory : Responsitory<Devvn_quanhuyen>, IDistrictResponsitory
    {
        private DbSet<Devvn_quanhuyen> m_district;
        public DistrictResponsitory(MyDBContext context) : base(context)
        {
            m_district = context.Set<Devvn_quanhuyen>();
        }
        public dynamic getDistrictByprovince(string pid)
        {
            return context.Devvn_quanhuyen.Where(x => x.matp == pid).ToList();
        }
    }
}

using ProjectWebShop.Model.units;
using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Interface.unit;
using System.Linq;
using WebApiMyShop.Data;

namespace ProjectWebShop.Responsitory.unit
{
    public class ProvinceResponsitory : Responsitory<Devvn_tinhthanhpho>, IProvinceResponsitory
    {
        private DbSet<Devvn_tinhthanhpho> m_province;
        public ProvinceResponsitory(MyDBContext context) : base(context)
        {
            m_province = context.Set<Devvn_tinhthanhpho>();
        }
        public dynamic getAllProvince()
        {
            return context.Devvn_tinhthanhpho.ToList();
        }
    }
}

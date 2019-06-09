using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model.units;

namespace ProjectWebShop.Interface.unit
{
    public interface IDistrictResponsitory : IResponsitory<Devvn_quanhuyen>
    {
        dynamic getDistrictByprovince(string pid);
    }
}

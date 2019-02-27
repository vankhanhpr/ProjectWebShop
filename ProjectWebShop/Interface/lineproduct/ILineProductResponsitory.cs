using ProjectWebShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Interface.lineproduct
{
    public interface ILineProductResponsitory
    {
        IEnumerable<LineProducts> GetAllLine();
        LineProducts GetLineById(int id);
        void SaveLineProduct(LineProducts linep);
        void DeleteLineProduct(int id);
        void UpdateLineProduct(LineProducts linep);
    }
}

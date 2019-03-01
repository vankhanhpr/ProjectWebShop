using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model;
using System.Collections.Generic;

namespace ProjectWebShop.Interface.product
{
    public interface IEvaluateResponsitory : IResponsitory<Evaluates>
    {
        dynamic GetAllEvaluates(int id);
        Evaluates GetEvaluatesById(int id);
        void SaveEvaluate(Evaluates ev);
        void DeleteEvaluate(int id);
        void UpdateEvaluate(Evaluates ev);
        dynamic GetEvaluatesByPr(int id);
    }
}

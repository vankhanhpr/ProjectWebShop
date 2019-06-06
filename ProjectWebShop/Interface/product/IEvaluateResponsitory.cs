using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model;
using System.Collections.Generic;

namespace ProjectWebShop.Interface.product
{
    public interface IEvaluateResponsitory : IResponsitory<Evaluate>
    {
        dynamic GetAllEvaluates();
        Evaluate GetEvaluatesById(int id);
        void SaveEvaluate(Evaluate ev);
        void DeleteEvaluate(int id);
        void UpdateEvaluate(Evaluate ev);
        List<Evaluate> GetEvaluatesByPr(int id);
    }
}

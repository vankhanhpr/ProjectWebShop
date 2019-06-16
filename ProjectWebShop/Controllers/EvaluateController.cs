using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Model;

namespace ProjectWebShop.Controllers
{
    [Route("api/evaluate")]
    [ApiController]
    public class EvaluateController : Controller
    {
        IEvaluateResponsitory m_ievaluateResponsitory;
        public EvaluateController(IEvaluateResponsitory ievaluateResponsitory)
        {
            m_ievaluateResponsitory = ievaluateResponsitory;
        }

       [HttpGet("getEvaByPr")]
       public DataRespond GetEvabyPr(int prid)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                var list = m_ievaluateResponsitory.GetEvaluatesByPr(prid);
                var listevar = new List<int>();
                foreach(var i in list)
                {
                    listevar.Add(i.evaluate);
                }
                var tb = Convert.ToInt32(listevar.Average());
                data.data = new { everage = tb, evaluate = m_ievaluateResponsitory.GetEvaluatesByPr(prid) };
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }
        [HttpPost("insertEva")]
        public DataRespond InsertEva()
        {
            DataRespond data = new DataRespond();
            return data;
        }
    }
}
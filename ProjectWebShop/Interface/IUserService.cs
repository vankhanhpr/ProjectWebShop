using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMyShop.Models;

namespace WebApiMyShop.Interface
{
    public interface IUserService
    {
        List<User> GetUserFilter(FilteringParams filteringParams);
    }
}

using ProjectWebShop.Interface.responsitory;
using ProjectWebShop.Model.register;
using System;
using System.Collections.Generic;

namespace ProjectWebShop.Interface.register
{
    public interface IRegisterResponsitory:IResponsitory<Register>
    {
        IEnumerable<Register> GetAllRegister(int page,int pagesize);
        string InsertRegister(Register register);
        void UpdateRegister(Register register);
        Boolean checkExistEmail(string email);
    }
}

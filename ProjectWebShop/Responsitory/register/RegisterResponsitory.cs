
using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Interface.register;
using ProjectWebShop.Model.register;
using System.Collections.Generic;
using System.Linq;
using WebApiMyShop.Data;

namespace ProjectWebShop.Responsitory.register
{
    public class RegisterResponsitory: Responsitory<Register>,IRegisterResponsitory
    {
        private DbSet<Register> registerEntity;
        public RegisterResponsitory(MyDBContext context):base(context)
        {
            registerEntity = context.Set<Register>();
        }

        public bool checkExistEmail(string email)
        {
            var rg = context.Register.Where(m=>m.email==email).FirstOrDefault();
            if (rg != null)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<Register> GetAllRegister(int page, int pagesize)
        {
            return context.Register.Where(m => m.status == 0).ToList().Skip(page*pagesize).Take(10);
        }

        public string InsertRegister(Register register)
        {
            if (!checkExistEmail(register.email))
            {
                context.Entry(register).State = EntityState.Added;
                context.SaveChanges();
                return "Cảm ơn quý khách đã đăng, chúng tôi sẽ gửi thông tin qua email cho quý khách!";
            }
            else
            {
                return "Email này đã được đăng kí trước đó, xin cảm ơn quý khách!";
            }
        }

        public void UpdateRegister(Register register)
        {
            context.Update(register);
            context.SaveChanges();
        }
    }
}

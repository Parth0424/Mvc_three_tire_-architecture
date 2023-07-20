using BussinessAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ManageRegistration
    {
        private readonly AppDbContext _appDbContext;
        public ManageRegistration(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddRegistration(RegistrationModel registrationModel)
        {
            Register reg = new Register()
            {
               
                Firstname = registrationModel.Firstname,
                LastName = registrationModel.LastName,
                Email = registrationModel.Email,
                Password = registrationModel.Password
            };
            _appDbContext.registers.Add(reg);
            _appDbContext.SaveChanges();
        }
    }
}

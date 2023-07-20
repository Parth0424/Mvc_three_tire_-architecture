using BussinessAccessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcPrac_1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPrac_1.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _appDbContext;
        ManageRegistration manageRegistration;
        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            manageRegistration = new ManageRegistration(_appDbContext);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(RegistrationModel registrationModel)
        {

            RegistrationModel Reg = new RegistrationModel()
            {
               
               Firstname=registrationModel.Firstname,
               LastName=registrationModel.LastName,
               Email=registrationModel.Email,
               Password=registrationModel.Password
            };
            manageRegistration.AddRegistration(Reg);
            return Ok("Record Inserted...");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}

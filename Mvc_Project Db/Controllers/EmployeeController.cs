using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Project_Db.Data;

namespace Mvc_Project_Db.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbcontext context;

        public EmployeeController()
        {
            context = new ApplicationDbcontext();
        }

        public ActionResult Index()
        {
            var employeelist = context.Employees.ToList();
            return View(employeelist);
        }
    }
}
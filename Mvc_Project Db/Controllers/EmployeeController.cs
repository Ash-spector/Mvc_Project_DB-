using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Project_Db.Data;
using Mvc_Project_Db.Models;

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
        /* GET: Employee/Create */
        public ActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (employee == null)
            {
                return HttpNotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var employeeIndb = context.Employees.Find(id);
            if (employeeIndb == null)
            {
                return HttpNotFound();
            }
            return View(employeeIndb);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (employee == null)
            {
                return HttpNotFound();
            }
            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            var employeeIndb = context.Employees.Find(employee.Id);
            if (employeeIndb == null)
            {
                return HttpNotFound();
            }
            employeeIndb.Name = employee.Name;
            employeeIndb.Address = employee.Address;
            employeeIndb.salary = employee.salary;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var employeeIndb = context.Employees.Find(id);
            if (employeeIndb == null)
            {
                return HttpNotFound();
            }
            return View(employeeIndb);
        }
        public ActionResult Delete(int id)
        {
            var employeeIndb = context.Employees.Find(id);
            if (employeeIndb == null)
            {
                return HttpNotFound();
            }
            return View(employeeIndb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Employee employee)
        {
            if (employee == null)
            {
                return HttpNotFound();
            }

            var employeeIndb = context.Employees.Find(employee.Id);
            if (employeeIndb == null)
            {
                return HttpNotFound();
            }

            context.Employees.Remove(employeeIndb);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
using jQueryAjaxInASP.NETMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQueryAjaxInASP.NETMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Employee
        public ActionResult ViewAll()
        {
            return View(GetAllEmployee());
        }

        IEnumerable<Employee> GetAllEmployee()
        {
            using (DBModel db = new DBModel())
            {
                return db.Employees.ToList<Employee>();
            }
        }

       // INSERT OPERATION

            // Default GET METHOD
       public ActionResult AddOrEdit(int id=0)
        {
            Employee emp = new Employee();
            return View(emp);
        }

          // POST METHOD
       [HttpPost]
       public ActionResult AddOrEdit()
        {
            return View();
        }
    }
}
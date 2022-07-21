using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCproject1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Employeeinfo()
        {
            Employee employee=new Employee()
            {
                Employeeid = 2022,
                Employeename = "Jhon abharam",
                Employeelocation = "Bangalure"
            };
                return View(employee);
        }
        
    }
}
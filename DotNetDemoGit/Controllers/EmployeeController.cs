using DotNetDemoGit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetDemoGit.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly PurchaseEntities1 _dbContext = new PurchaseEntities1();

        public ActionResult Index()
        {
            var employees = _dbContext.Employees.ToList();
            return View(employees);
        }

    }
}

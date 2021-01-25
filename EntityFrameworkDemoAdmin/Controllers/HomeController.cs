using EntityFrameworkDemoAdmin.Abstract;
using EntityFrameworkDemoAdmin.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkDemoAdmin.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _data;

        public HomeController()
        {
            _data = new DataStorage();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(_data.Customers);
        }
    }
}
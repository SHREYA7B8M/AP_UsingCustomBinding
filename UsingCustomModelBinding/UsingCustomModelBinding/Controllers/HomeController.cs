using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsingCustomModelBinding.Models;

namespace UsingCustomModelBinding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult StudentEditView()
        {
            return View();
        }

        [HttpPost]
        public ContentResult StudentEditView(StudentModel model)
        {
            String result = model.Name + "," + model.Address + "," + model.WhichClass + "," + model.TotalMarks.ToString();
            return Content("Form was submitted:\n" + result);
        }

    }
}
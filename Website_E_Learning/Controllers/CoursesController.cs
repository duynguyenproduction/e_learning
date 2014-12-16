using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Website_E_Learning.Controllers
{
    public class CoursesController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Course for User!";
            return View();
        }

        public ActionResult ShowCourse()
        {
            return View();
        }
    }
}

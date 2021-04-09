using Exam.Business;
using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(ModelUSer input)
        {
            var Output = Rules.SaveUser(input);
            return Json(new { data = Output }, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public ActionResult GetAll()
        {
            var Output = Rules.Getall();
            return Json(new { data = Output }, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public ActionResult Edit(ModelId input)
        {
            var Output = Rules.Edit(input);
            return Json(new { data = Output }, JsonRequestBehavior.AllowGet);

        }

    }
}
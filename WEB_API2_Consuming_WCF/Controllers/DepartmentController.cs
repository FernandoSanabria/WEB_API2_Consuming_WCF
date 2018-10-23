using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_API2_Consuming_WCF.ServiceReference1;

namespace WEB_API2_Consuming_WCF.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult GetDeptos()
        {
            Service1Client o = new Service1Client();
            List<Department> li = o.GetDep().ToList();
            ViewBag.List = li;
            return View();
        }

        public ActionResult InsertDep()
        {

            return View();
        }

        [HttpPost]
        public ActionResult InsertDep(Department obj)
        {
            Service1Client o = new Service1Client();
            o.InsertDep(obj);
            return View();
        }

        public ActionResult UpdateDepto()
        {

            return View();
        }

        [HttpPost]
        public ActionResult UpdateDepto(Department obj)
        {
            Service1Client o = new Service1Client();
            o.UpdateDep(obj);
            return View();
        }

        public ActionResult DeleteDepto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteDepto(string id)
        {
            Service1Client o = new Service1Client();
            o.DeleteDep(id);
            return View();
        }

    }
}
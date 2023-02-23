using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SristyLearn.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Contact()
        {
        
            return View();
        }
        [HttpPost]
        /* public ActionResult Contact(int a=0)
         {
             ViewBag.Name =Request["Name"];
             ViewBag.ID = Request["id"];
             return View();
         }*/
        /*public ActionResult Contact(FormCollection form)
        {
            ViewBag.Name = form["Name"];
             ViewBag.ID = form["id"];
            return View();
        }*/
        public ActionResult Contact(string Name,string id)
        {
            ViewBag.Name = Name;
            ViewBag.Id = id;
            return View();
        }
    }
}
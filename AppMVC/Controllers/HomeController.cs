using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ActionResult = System.Web.Mvc.ActionResult;
using Controller = System.Web.Mvc.Controller;

namespace AppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UsingIFrame()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult RequestAlgo()
        {

            Algo algo = new Algo();

            algo.AlgumaCoisa = "AlgumaCoisa";
            algo.AlgumaOutraCoisa = "AlgumaOutraCoisa";

            return Content(JsonConvert.SerializeObject(algo), "application/json");
        }

        public ActionResult UsingExternalApplicationRoute()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }       
        public ActionResult UsingInjectById()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }       
        public ActionResult UsingWebComponents()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
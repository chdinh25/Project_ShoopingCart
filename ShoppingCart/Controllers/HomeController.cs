using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartV2.Models;

namespace ShoppingCartV2.Controllers
{
    public partial class HomeController : Controller
    {
        // Text for Site Heading
        string siteHeading = "The Used Computer Parts";

        // Text for Order View Heading
        string orderHeading = "Part Orders";

        // Text for View Heading for each Tab
        string[] tabHeadings = { "Home", "CPUs and Processors", "Graphics Cards", "Storage Solutions",
                                         "Check-Out", "Admin", "About" };

        // View label displayed on each Tab
        string[] tabLabels = { "Home", "CPUs and Processors", "Graphics Cards", "Storage Solutions",
                                       "Check-Out", "Admin", "About" };

        // View method name for each Tab
        string[] tabViews = { "Index", "Tab1", "Tab2", "Tab3",
                                       "CheckOut", "Admin", "About" };

        // Text for View Heading of any Options columns
        string[] optionsColumnHeading = { "", "Options",
                                              "Options", "Options", "" };

        // The tax rate is 6%
        decimal taxRate = 0.06M;

        // Action Method for Home page View
        public ActionResult Index()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "Welcome To " + siteHeading;
            ViewBag.Message2 = "<img src=\"/Images/logo1.jpg\">";
            ViewBag.Message2 += "<br/>Revitalize Your Tech Experience with Quality Used Parts. <br/>";
            ViewBag.Message2 += "Upgrade Smarter, Explore Better!";
            return View();
        }

        // Action Method for About page View
        public ActionResult About()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "About " + siteHeading;
            ViewBag.Message2 = "<img src=\"/Images/aboutus.jpg\">";
            ViewBag.Message2 += "<br />Welcome to our website, where cool things can be found. <br/>";
            ViewBag.Message2 += "I'm Thanh, the Webmaster of this website. Thanks for visiting and being a part of our cool community! <br/>";
            ViewBag.Message2 += "<br/>";
            ViewBag.Message2 += "Please explore our website for the latest tech deals!";
            return View();
        }

        // Action Method for First Product View
        public ActionResult Tab1()
        {
            return GetTabView(1);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab1(string button, FormCollection collection)
        {
            return ProcessTabView(1, button, collection);
        }

        // Action Method for Second Product View
        public ActionResult Tab2()
        {
            return GetTabView(2);
        }
        // Action Method for Second Product View
        [HttpPost]
        public ActionResult Tab2(string button, FormCollection collection)
        {
            return ProcessTabView(2, button, collection);
        }

        // Action Method for Third Product View
        public ActionResult Tab3()
        {
            return GetTabView(3);
        }
        // Action Method for Third Product View
        [HttpPost]
        public ActionResult Tab3(string button, FormCollection collection)
        {
            return ProcessTabView(3, button, collection);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartV2.Models;

/*
*Course: CS 3410
* Section: W02
 *Name: Dion Green
 *Professor: Lingyan Wang
 *Assignment #: Module Assignment #8
 */

namespace ShoppingCartV2.Controllers
{
    public partial class HomeController : Controller
    {
        // Text for Site Heading
        string siteHeading = "The Cabinet of Mixtures & Elixirs";

        // Text for Order View Heading
        string orderHeading = "Potion and Mixtures";

        // Text for View Heading for each Tab
        string[] tabHeadings = { "Home", "Body Potions","Affect Potion","Beyond",
                                         "Check-Out", "Admin", "About" };

        // View label displayed on each Tab
        string[] tabLabels = { "Home", "Pot1","Pot2","Pot3",
                                       "Check-Out", "Admin", "About" };

        // View method name for each Tab
        string[] tabViews = { "Index", "Tab1Orders","Tab2Orders","Tab3Orders",
                                       "CheckOut", "Admin", "About" };

        // Text for View Heading of any Options columns
        string[] optionsColumnHeading = { "", "Body Potion Opt","Affect Potion Opt","Beyond Opt",
                                              "", "", "" };

        // The tax rate is 5%
        decimal taxRate = 0.05M;

        // Action Method for Home page View
        public ActionResult Index()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "Welcome To " + siteHeading;
            ViewBag.Message2 = "<img src=\"/Images/newlogo.jpg\">";
            ViewBag.Message2 += "<br />Explore the Mixtures and Elixirs";
            return View();
        }

        // Action Method for About page View
        public ActionResult About()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "About " + siteHeading;
            ViewBag.Message2 = "Dion you personal Mixtures and Elixir master";
            ViewBag.Message3 = "<img src=\"/Images/aboutimage.jpeg\">";
            return View();
        }

        // Action Method for First Product View
        public ActionResult Tab1Orders()
        {
            return GetTabView(1);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab1Orders(string button, FormCollection collection)
        {
            return ProcessTabView(1, button, collection);
        }

        public ActionResult Tab2Orders()
        {
            return GetTabView(2);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab2Orders(string button, FormCollection collection)
        {
            return ProcessTabView(2, button, collection);
        }


        public ActionResult Tab3Orders()
        {
            return GetTabView(3);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab3Orders(string button, FormCollection collection)
        {
            return ProcessTabView(3, button, collection);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BallerinaCappucina01.Controllers
{
    public class ZamowieniaViewController : Controller
    {

            public ActionResult Kiosk()
            {
                ViewBag.ActiveTab = "Kawa";
                return View();
            }

            public ActionResult Kiosk2()
            {
                ViewBag.ActiveTab = "Herbata";
                return View();
            }

            public ActionResult Kiosk3()
            {
                ViewBag.ActiveTab = "Ciasta";
                return View();
            }

            public ActionResult Zamowienie()
            {
                return View();
            }
        }
    }


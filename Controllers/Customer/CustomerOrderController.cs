﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BhavnasERP.Controllers.Customer
{
    public class CustomerOrderController : Controller
    {
        // GET: CustomerOrder
        public ActionResult CustomerOrderIndex()
        {
            return View();
        }
    }
}
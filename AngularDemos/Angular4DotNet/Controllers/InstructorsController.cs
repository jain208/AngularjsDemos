﻿using Angular4DotNet.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class InstructorsController : Controller
    {
        //
        // GET: /Courses/
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();
        public JsonResult GetInstructors()
        {
            return Json(_registrationVmBuilder.GetInstructors(), JsonRequestBehavior.AllowGet);
        }

    }
}
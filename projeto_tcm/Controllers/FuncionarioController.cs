﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto_tcm.Controllers
{
    [Route("funcionario")]
    public class FuncionarioController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
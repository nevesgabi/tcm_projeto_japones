using projeto_tcm.Models;
using projeto_tcm.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto_tcm.Controllers
{
    public class MesaController : Controller
    {
        public ActionResult Mesas()
        {
            return View();
        }

        public ActionResult ConsultarMesas()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarMesas(Mesaa mesa)
        {
            Mesaas me = new Mesaas();
            me.CadastroMesa(mesa);

            return RedirectToAction("ConsultarMesas", mesa);
        }
    }
}
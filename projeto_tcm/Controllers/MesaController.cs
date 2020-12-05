using projeto_tcm.Models;
using projeto_tcm.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto_tcm.Controllers
{
    [Route("mesa")]
    public class MesaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ConsultarMesas(int id)
        {
            Mesaas me = new Mesaas();
            Mesaa resultado = me.ConsultarMesa(id);
            return View(resultado);
        }

        [HttpPost]
        public ActionResult CadastrarMesas(Mesaa body)
        {
            Mesaas me = new Mesaas();
            me.CadastroMesa(body);

            return RedirectToAction("ConsultarMesas", body);
        }
    }
}
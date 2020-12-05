using projeto_tcm.Models;
using projeto_tcm.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto_tcm.Controllers
{
    public class ComandaController : Controller
    {
        public ActionResult Comanda()
        {
            return View();
        }

        public ActionResult ConsultarComanda()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarComanda(Comanda comanda)
        {

            Comandas cd = new Comandas();
            cd.CadastroComanda(comanda);

            return RedirectToAction("ConsultarComanda", comanda);
        }
    }
}
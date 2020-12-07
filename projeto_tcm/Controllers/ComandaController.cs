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

        public ActionResult ConsultarComanda(int idComanda)
        {
            Comandas repositorio = new Comandas();
            Comanda comanda = repositorio.ConsultarComanda(idComanda);
            return View(comanda);
        }

        [HttpPost]
        public ActionResult CadastrarComanda(Comanda comanda)
        {
            Comandas repositorio = new Comandas();
            long id = repositorio.CadastroComanda(comanda);

            return RedirectToAction("ConsultarComanda", new { idComanda = id });

        }

        public ActionResult ListarTodasComandas()
        {
            Comandas repositorio = new Comandas();
            List<Comanda> comandas = repositorio.ListarTodasComandas();

            return View(comandas);
        }

        [HttpPost]
        public ActionResult DeletarComanda(int idComanda)
        {
            Comandas repositorio = new Comandas();
            repositorio.DeletarComanda(idComanda);
            return RedirectToAction("Comanda");
        }
    }
}
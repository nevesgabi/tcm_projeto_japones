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

        public ActionResult ConsultarMesas(int idMesa)
        {
            Mesaas repositorio = new Mesaas();
            Mesaa mesa = repositorio.ConsultarMesas(idMesa);
            return View(mesa);
        }

        [HttpPost]
        public ActionResult CadastrarMesas(Mesaa body)
        {
            Mesaas repositorio = new Mesaas();
            long id = repositorio.CadastroMesa(body);

            return RedirectToAction("ConsultarMesas", new { idMesa = id });
        }

        public ActionResult ListarTodasMesas()
        {
            Mesaas repositorio = new Mesaas();
            List<Mesaa> mesas = repositorio.ListarTodasMesas();

            return View(mesas);
        }

        [HttpPost]
        public ActionResult DeletarMesa(int idMesa)
        {
            Mesaas repositorio = new Mesaas();
            repositorio.DeletarMesa(idMesa);
            return RedirectToAction("Index");
        }
    }
}
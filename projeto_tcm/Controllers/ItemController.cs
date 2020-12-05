using projeto_tcm.Models;
using projeto_tcm.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto_tcm.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult Item()
        {
            return View();
        }

        public ActionResult ConsultarItem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarItem(Item item)
        {

            Itens it = new Itens();
            it.CadastroItem(item);

            return RedirectToAction("ConsultarItem", item);
        }
    }
}
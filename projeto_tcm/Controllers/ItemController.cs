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

        public ActionResult ConsultarItem(int idItem)
        {
            Itens repositorio = new Itens();
            Item item = repositorio.ConsultarItem(idItem);
            return View(item);
        }

        public ActionResult ListaTodosItens()
        {
            Itens repositorio = new Itens();
            List<Item> itens = repositorio.ListaTodosItens();

            return View(itens);
        }

        [HttpPost]
        public ActionResult CadastrarItem(Item item)
        {

            Itens repositorio = new Itens();
            long id = repositorio.CadastroItem(item);

            return RedirectToAction("ConsultarItem", new { idItem = id });
        }

        [HttpPost]
        public ActionResult DeletarItem(int idItem)
        {
            Itens repositorio = new Itens();
            repositorio.DeletarItem(idItem);
            return RedirectToAction("Item");
        }
    }
}
using projeto_tcm.Models;
using projeto_tcm.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto_tcm.Controllers
{
    public class PagamentoController : Controller
    {
        public ActionResult Pagamento()
        {
            return View();
        }

        public ActionResult ConsultarPagamento()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarPagamento(Pagamento pagamento)
        {

            Pagamentoo pg = new Pagamentoo();
            pg.CadastroPagamento(pagamento);

            return RedirectToAction("ConsultarPagamento", pagamento);
        }
    }
}
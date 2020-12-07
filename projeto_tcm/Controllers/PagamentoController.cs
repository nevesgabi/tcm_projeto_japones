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

        public ActionResult ConsultarPagamento(int idPagamento)
        {
            Pagamentoo repositorio = new Pagamentoo();
            Pagamento pagamento = repositorio.ConsultarPagamento(idPagamento);
            return View(pagamento);
        }

        [HttpPost]
        public ActionResult CadastrarPagamento(Pagamento pagamento)
        {

            Pagamentoo repositorio = new Pagamentoo();
            long id = repositorio.CadastroPagamento(pagamento);

            return RedirectToAction("ConsultarPagamento", new { idPagamento = id });
        }

        [HttpPost]
        public ActionResult DeletarPagamento(int idPagamento)
        {
            Pagamentoo repositorio = new Pagamentoo();
            repositorio.DeletarPagamento(idPagamento);
            return RedirectToAction("pagamento");
        }

        public ActionResult ListarTodosPagamentos()
        {
            Pagamentoo repositorio = new Pagamentoo();
            List<Pagamento> pagamentos = repositorio.ListarTodosPagamentos();

            return View(pagamentos);
        }
    }
}
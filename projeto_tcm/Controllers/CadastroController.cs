using projeto_tcm.Models;
using projeto_tcm.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto_tcm.Controllers
{
    [Route("cadastro")]
    public class CadastroController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ConsultarCadastro(int idFunc)
        {
            Funcionario func = new Funcionario();
            Cadastro fu = func.ConsultarFuncionario(idFunc);
            return View(fu);
        }

        [HttpPost]
        public ActionResult DeletarCadastro(int idFunc)
        {
            Funcionario func = new Funcionario();
            func.DeletarFuncionario(idFunc);
            return RedirectToAction("Index");
        }

        public ActionResult ListarTodos()
        {
            Funcionario func = new Funcionario();
            List<Cadastro> funcionarios = func.ListarTodos();

            return View(funcionarios);
        }

        [HttpPost]
        public ActionResult CadastrarFuncionario(Cadastro cadastro)
        {

            Funcionario ac = new Funcionario();
            long id = ac.CadastroFuncionario(cadastro);

            return RedirectToAction("ConsultarCadastro", new { idFunc = id });
        }
    }
}
using projeto_tcm.Models;
using projeto_tcm.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto_tcm.Controllers
{
    [Route("funcionario")]
    public class FuncionarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ConsultarCadastro(int idFunc)
        {
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            FuncionarioModel funcionario = repositorio.ConsultarFuncionario(idFunc);
            return View(funcionario);
        }

        [HttpPost]
        public ActionResult DeletarCadastro(int idFunc)
        {
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            repositorio.DeletarFuncionario(idFunc);
            return RedirectToAction("Index");
        }

        public ActionResult ListarTodos()
        {
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            List<FuncionarioModel> funcionarios = repositorio.ListarTodos();

            return View(funcionarios);
        }

        [HttpPost]
        public ActionResult CadastrarFuncionario(FuncionarioModel cadastro)
        {

            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            long id = repositorio.CadastroFuncionario(cadastro);

            return RedirectToAction("ConsultarCadastro", new { idFunc = id });
        }
    }
}
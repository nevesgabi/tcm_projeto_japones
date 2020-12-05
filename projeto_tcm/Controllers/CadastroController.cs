using projeto_tcm.Models;
using projeto_tcm.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto_tcm.Controllers
{
    public class CadastroController : Controller
    {
        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult ConsultarCadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarFuncionario(Cadastro cadastro)
        {

            Funcionario ac = new Funcionario();
            ac.CadastroFuncionario(cadastro);

            return RedirectToAction("ConsultarCadastro", cadastro);
        }
    }
}
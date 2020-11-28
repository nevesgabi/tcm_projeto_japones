using projeto_tcm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace projeto_tcm.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VerificarUsuario(UserLogin u)
        {
            if (u.nome_usuario != null && u.senha != null)
            {
                FormsAuthentication.SetAuthCookie(u.nome_usuario, false);
                Session["usuario"] = u.nome_usuario.ToString();
                Session["senha"] = u.senha.ToString();

                //direcionar o usuario para a página index da home
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
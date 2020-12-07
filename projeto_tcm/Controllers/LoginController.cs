using projeto_tcm.Models;
using projeto_tcm.Repositorio;
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
            LoginRepositorio repo = new LoginRepositorio();
            UserLogin resultado = repo.TestarUsuario(u);

            if (resultado.nome_usuario != null && resultado.senha != null)
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
       
        public ActionResult Logout()
        {
            Session["usuario"] = null;
            return RedirectToAction("Index", "Login");
        }

        }
    }
using Reposteria.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Reposteria.WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        SeguridadBL _seguridadBL;

        public LoginController()
        {
            _seguridadBL = new SeguridadBL();
        }

        // GET: Login
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection data)
        {
            var nombreUsuario = data["username"];//el username sale de la plantilla 
            var contrasena = data["password"];

            var usuarioValido = _seguridadBL.Autorizar(nombreUsuario, contrasena);

            if (usuarioValido)
            {
                FormsAuthentication.SetAuthCookie(nombreUsuario, true); //para guardar la cookie en el navegador y dar acceso a las opciones del programa
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Usuario o contraseña inválido");

            return View();
        }
             
    }
}
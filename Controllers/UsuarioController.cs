using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Laboratorio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Laboratorio1.Controllers
{
    public class UsuarioController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("LogueadoNombre") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            Usuario logueado = s.Login(email, password);

            if (logueado != null)
            {
                HttpContext.Session.SetString("LogueadoNombre", logueado.Nombre);

                ViewBag.Resultado = "Logueado con exito";

            }else
            {
                ViewBag.Resultado = "Error de password";
            }

            return View();
        }
    }
}

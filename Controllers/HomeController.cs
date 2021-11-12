using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Laboratorio1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Laboratorio1.Controllers
{
    public class HomeController : Controller
    {
       Sistema s = Sistema.GetInstancia();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
        
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("LogueadoNombre") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        public IActionResult Logout()
        {
           HttpContext.Session.Clear();

            return View();
        }

        public IActionResult Privacy()
        {
            //string nombreUsuario = "Juan" es lo mismo 
            //HttpContext.Session.SetString("nombreUsuario","Jose");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

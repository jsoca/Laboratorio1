using Microsoft.AspNetCore.Mvc;
using MVC_Laboratorio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Laboratorio1.Controllers
{
    public class ClienteController : Controller
    {

        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            ViewBag.listaClientes = s.GetClientes();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Cliente nuevo = s.AltaCliente(nombre, apellido, fechaNacimiento);
            if (nuevo != null)
            {
                ViewBag.Resultado = "Alta Correcta";
            }
            else {
                ViewBag.Resultado = "Error al realizar el alta";
            }
            return View();
        }


        public IActionResult Edit(int id)
        {
            Cliente buscado = s.GetCliente(id);
            ViewBag.Cliente = buscado;
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string nombre, string apellido, DateTime fechaNacimiento)
        {
            Cliente buscado = s.GetCliente(id);
            ViewBag.Cliente = buscado;

            bool cambio = s.ModificarCliente(id, nombre, apellido, fechaNacimiento);

            if (cambio)
            {
                ViewBag.Resultado = "Cambio realizado";
            }
            else {
                ViewBag.Resultado = "Error de edición";
            }


            return View();
        }

        public IActionResult DeleteCli(int id)
        {
            s.DeleteCli(id);



            ViewBag.Msg = "Usuario Eliminado";

            return View();
        }

    }
}

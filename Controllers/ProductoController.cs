using Microsoft.AspNetCore.Mvc;
using MVC_Laboratorio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Laboratorio1.Controllers
{
    public class ProductoController : Controller
    {

        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            ViewBag.listaProductos = s.GetProductos();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string nombre, string categoria, double precio)
        {
            Producto nuevo = s.AltaProducto(nombre, categoria,precio);
            if (nuevo != null)
            {
                ViewBag.Resultado2 = "Alta Correcta";
            }
            else
            {
                ViewBag.Resultado2 = "Error al realizar el alta";
            }
            return View();
        }


        public IActionResult Edit(int id)
        {
            Producto buscado = s.GetProducto(id);
            ViewBag.Producto = buscado;
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id,string nombre, string categoria, bool estado, double precio)
        {
            Producto buscado = s.GetProducto(id);
            ViewBag.Producto = buscado;

            bool cambio = s.ModificarProducto(id,nombre, categoria, estado, precio);

            if (cambio)
            {
                ViewBag.Resultado2 = "Cambio realizado";
            }
            else
            {
                ViewBag.Resultado2 = "Error de edición";
            }


            return View();
        }
        public IActionResult Delete(int id)
        {
            s.Delete(id);

            ViewBag.Msg = "Producto Eliminado";

            return View();
        }

    }
}
 
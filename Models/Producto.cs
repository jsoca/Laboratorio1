using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Laboratorio1.Models
{
    public class Producto
    {
        private static int ultimoId = 1;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public bool Estado { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, string categoria, double precio)
        {
            Id = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Categoria = categoria;
            Estado = true;
            Precio = precio;
        }

    }
}

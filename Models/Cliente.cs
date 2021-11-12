using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Laboratorio1.Models
{
    public class Cliente
    {
        private static int ultimoId = 1;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaNacimiento{ get; set; }


        public Cliente(string nombre, string apellido, DateTime fnac)
        {
            Id = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Estado = true;
            FechaNacimiento = fnac;
        }
      

   
    }
}

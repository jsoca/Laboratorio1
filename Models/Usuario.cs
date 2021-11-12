using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Laboratorio1.Models
{
    public class Usuario
    {
        private static int ultimoId = 1;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Usuario(string nombre, string apellido, string email, string password)
        {
            Id = ultimoId;
            ultimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;

        }
        public Usuario()
        {

        }
    }
}

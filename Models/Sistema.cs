using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Laboratorio1.Models
{
    public class Sistema
    {
        private List<Producto> productos = new List<Producto>();

        private List<Cliente> clientes = new List<Cliente>();

        private List<Usuario> usuarios = new List<Usuario>();
        internal List<Producto> GetProductos() { return productos; }
        internal List<Cliente> GetClientes() { return clientes; }

        internal List<Usuario> GetUsuarios() { return usuarios; }
        private Sistema()
        {
            Precarga();

       
       
            Precarga2();
        }

           
        

        private static Sistema instancia = null;

        public static Sistema GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Sistema();
            }

            return instancia;
        }

       internal Usuario AltaUsuario(string nombre, string apellido, string email, string password)
       {
            Usuario us = null;
            if(nombre !=null && apellido != null && email != null && password != null)
            {
                us = new Usuario(nombre, apellido, email, password);
                usuarios.Add(us);
            }
            return us;
        }

        internal Usuario Login(string email, string password)
        {
            Usuario ret = null;
            foreach (Usuario u in usuarios)
            {
                if (u.Email.Equals(email) && u.Password.Equals(password))
                {
                    ret = u;
                }
               
            }
            return ret;
        }

        internal Producto AltaProducto(string nombre, string categoria, double precio)
        {
            Producto prod = null;
            if (nombre != null && categoria != null && precio > 0)
            {
                prod = new Producto(nombre, categoria, precio);
                productos.Add(prod);
            }
            return prod;
        }

        internal bool Delete(int id)
        {
            bool ret = false;
            foreach (Producto p in productos)
            {
                if (p.Id.Equals(id))
                {
                    p.Estado = false;
                    ret = true;
                }
            }
            return ret;
        }
        internal bool DeleteCli(int id)
        {
            bool ret = false;

            foreach (Cliente c in clientes)
            {
                if (c.Id.Equals(id))
                {
                    c.Estado = false;
                    ret = true;
                }
            }
            return ret;
        }

        internal bool ModificarProducto(int id, string nombre, string categoria, bool estado, double precio)
        {
            bool ret = false;
            foreach (Producto p in productos)
            {
                if (p.Id.Equals(id))
                {
                    p.Nombre = nombre;
                    p.Categoria = categoria;
                    p.Estado = estado;
                    p.Precio = precio;
                    ret = true;
                }
            }
            return ret;

        }

        internal bool ModificarCliente(int id, string nombre, string apellido, DateTime fechaNacimiento)
        {
            bool ret = false;
            foreach (Cliente c in clientes)
            {
                if (c.Id.Equals(id))
                {
                    c.Nombre = nombre;
                    c.Apellido = apellido;
                    c.FechaNacimiento = fechaNacimiento;
                    ret = true;
                }
            }
            return ret;
        }

        public Cliente GetCliente(int id) {
            Cliente b = null;
            foreach (Cliente c in clientes) {
                if (c.Id.Equals(id)) {
                    b = c;
                }
            }
            return b;
        }
         public Producto GetProducto(int id) {
            Producto b = null;
            foreach (Producto p in productos) {
                if (p.Id.Equals(id)) {
                    b = p;
                }
            }
            return b;
        }

       

        public Cliente AltaCliente(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Cliente cli = null;
            if (nombre != null && apellido != null && fechaNacimiento < DateTime.Now)
            {
                cli = new Cliente(nombre, apellido,fechaNacimiento);
                clientes.Add(cli);
            }
            return cli;
        }



        private void Precarga()
        {

            Producto p1 = AltaProducto("Té Dharamsala", "Bebidas", 18);
            Producto p2 = AltaProducto("Cerveza tibetana Barley", "Bebidas", 19);
            Producto p3 = AltaProducto("Sirope de regaliz", "Condimentos", 10);
            Producto p4 = AltaProducto("Especias Cajun del chef Anton", "Condimentos", 22);
            Producto p5 = AltaProducto("Mezcla Gumbo del chef Anton", "Condimentos", 21);
            Producto p6 = AltaProducto("Mermelada de grosellas de la abuela", "Condimentos", 25);
            Producto p7 = AltaProducto("Peras secas orgánicas del tío Bob", "Frutas/Verduras", 30);
            Producto p8 = AltaProducto("Salsa de arándanos Northwoods", "Condimentos", 40);
            Producto p9 = AltaProducto("Buey Mishi Kobe", "Carnes", 97);
            Producto p10 = AltaProducto("Pez espada", "Pescado/Marisco", 31);
            Producto p11 = AltaProducto("Queso Cabrales", "Lácteos", 21);
            Producto p12 = AltaProducto("Queso Manchego La Pastora", "Lácteos", 38);
            Producto p13 = AltaProducto("Algas Konbu", "Pescado/Marisco", 6);
            Producto p14 = AltaProducto("Cuajada de judías", "Frutas/Verduras", 23);
            Producto p15 = AltaProducto("Salsa de soja baja en sodio", "Condimentos", 16);
            Producto p16 = AltaProducto("Postre de merengue Pavlova", "Repostería", 17);
            Producto p17 = AltaProducto("Cordero Alice Springs", "Carnes", 39);
            Producto p18 = AltaProducto("Langostinos tigre Carnarvon", "Pescado/Marisco", 63);
            Producto p19 = AltaProducto("Pastas de té de chocolate", "Repostería", 9);
            Producto p20 = AltaProducto("Mermelada de Sir Rodney's", "Repostería", 81);
            Producto p21 = AltaProducto("Bollos de Sir Rodney's", "Repostería", 10);
            Producto p22 = AltaProducto("Pan de centeno crujiente estilo Gustaf's", "Granos/Cereales", 21);
            Producto p23 = AltaProducto("Pan fino", "Granos/Cereales", 9);
            Producto p24 = AltaProducto("Refresco Guaraná Fantástica", "Bebidas", 5);
            Producto p25 = AltaProducto("Crema de chocolate y nueces NuNuCa", "Repostería", 14);
            Producto p26 = AltaProducto("Ositos de goma Gumbär", "Repostería", 31);
            Producto p27 = AltaProducto("Chocolate Schoggi", "Repostería", 44);
            Producto p28 = AltaProducto("Col fermentada Rössle", "Frutas/Verduras", 46);
            Producto p29 = AltaProducto("Salchicha Thüringer", "Carnes", 124);
            Producto p30 = AltaProducto("Arenque blanco del noroeste", "Pescado/Marisco", 26);
            Producto p31 = AltaProducto("Queso gorgonzola Telino", "Lácteos", 13);
            Producto p32 = AltaProducto("Queso Mascarpone Fabioli", "Lácteos", 32);
            Producto p33 = AltaProducto("Queso de cabra", "Lácteos", 3);
            Producto p34 = AltaProducto("Cerveza Sasquatch", "Bebidas", 14);
            Producto p35 = AltaProducto("Cerveza negra Steeleye", "Bebidas", 18);
            Producto p36 = AltaProducto("Escabeche de arenque", "Pescado/Marisco", 19);
            Producto p37 = AltaProducto("Salmón ahumado Gravad", "Pescado/Marisco", 26);
            Producto p38 = AltaProducto("Vino Côte de Blaye", "Bebidas", 264);
            Producto p39 = AltaProducto("Licor verde Chartreuse", "Bebidas", 18);
            Producto p40 = AltaProducto("Carne de cangrejo de Boston", "Pescado/Marisco", 18);
            Producto p41 = AltaProducto("Crema de almejas estilo Nueva Inglaterra", "Pescado/Marisco", 10);
            Producto p42 = AltaProducto("Tallarines de Singapur", "Granos/Cereales", 14);
            Producto p43 = AltaProducto("Café de Malasia", "Bebidas", 46);
            Producto p44 = AltaProducto("Azúcar negra Malacca", "Condimentos", 19);
            Producto p45 = AltaProducto("Arenque ahumado", "Pescado/Marisco", 10);
            Producto p46 = AltaProducto("Arenque salado", "Pescado/Marisco", 12);
            Producto p47 = AltaProducto("Galletas Zaanse", "Repostería", 10);
            Producto p48 = AltaProducto("Chocolate holandés", "Repostería", 13);
            Producto p49 = AltaProducto("Regaliz", "Repostería", 20);
            Producto p50 = AltaProducto("Chocolate blanco", "Repostería", 16);
            Producto p51 = AltaProducto("Manzanas secas Manjimup", "Frutas/Verduras", 53);
            Producto p52 = AltaProducto("Cereales para Filo", "Granos/Cereales", 7);
            Producto p53 = AltaProducto("Empanada de carne", "Carnes", 33);
            Producto p54 = AltaProducto("Empanada de cerdo", "Carnes", 7);
            Producto p55 = AltaProducto("Paté chino", "Carnes", 24);
            Producto p56 = AltaProducto("Gnocchi de la abuela Alicia", "Granos/Cereales", 38);
            Producto p57 = AltaProducto("Raviolis Angelo", "Granos/Cereales", 20);
            Producto p58 = AltaProducto("Caracoles de Borgoña", "Pescado/Marisco", 13);
            Producto p59 = AltaProducto("Raclet de queso Courdavault", "Lácteos", 55);
            Producto p60 = AltaProducto("Camembert Pierrot", "Lácteos", 34);
            Producto p61 = AltaProducto("Sirope de arce", "Condimentos", 29);
            Producto p62 = AltaProducto("Tarta de azúcar", "Repostería", 49);
            Producto p63 = AltaProducto("Sandwich de vegetales", "Condimentos", 44);
            Producto p64 = AltaProducto("Bollos de pan de Wimmer", "Granos/Cereales", 33);
            Producto p65 = AltaProducto("Salsa de pimiento picante de Luisiana", "Condimentos", 21);
            Producto p66 = AltaProducto("Especias picantes de Luisiana", "Condimentos", 17);
            Producto p67 = AltaProducto("Cerveza Laughing Lumberjack", "Bebidas", 14);
            Producto p68 = AltaProducto("Barras de pan de Escocia", "Repostería", 13);
            Producto p69 = AltaProducto("Queso Gudbrandsdals", "Lácteos", 36);
            Producto p70 = AltaProducto("Cerveza Outback", "Bebidas", 15);
            Producto p71 = AltaProducto("Crema de queso Fløtemys", "Lácteos", 22);
            Producto p72 = AltaProducto("Queso Mozzarella Giovanni", "Lácteos", 35);
            Producto p73 = AltaProducto("Caviar rojo", "Pescado/Marisco", 15);
            Producto p74 = AltaProducto("Queso de soja Longlife", "Frutas/Verduras", 10);
            Producto p75 = AltaProducto("Cerveza Klosterbier Rhönbräu", "Bebidas", 8);
            Producto p76 = AltaProducto("Licor Cloudberry", "Bebidas", 18);
            Producto p77 = AltaProducto("Salsa verde original Frankfurter", "Condimentos", 13);

            p70.Estado = false;
            p71.Estado = false;
            p72.Estado = false;
            p73.Estado = false;
            p74.Estado = false;
            p75.Estado = false;
            p76.Estado = false;
            p77.Estado = false;




            Cliente c1 = AltaCliente("Juan", "Perez", DateTime.Parse("1984-10-10"));
            Cliente c2 = AltaCliente("Ana", "Fernández", DateTime.Parse("1961-04-20"));
            Cliente c3 = AltaCliente("María", "González", DateTime.Parse("1999-02-01"));
            Cliente c4 = AltaCliente("Juan", "Rodríguez", DateTime.Parse("1989-05-18"));
            Cliente c5 = AltaCliente("Ana", "García", DateTime.Parse("2000-05-03"));
            Cliente c6 = AltaCliente("Lucía", "Martínez", DateTime.Parse("1996-01-01"));
            Cliente c7 = AltaCliente("Alberto", "Silva", DateTime.Parse("1972-09-11"));
        }
        ////////
        
private void Precarga2()
        {

            Usuario u1 = AltaUsuario("Juan", "Perez", "juan@mail.com", "j1234");
            Usuario u2 = AltaUsuario("Ana", "Martínez", "ana@mail.com", "a1234");
        }

    }
}

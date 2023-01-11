using System;

namespace Excercise3struct
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente c1 = new cliente("Juan Perez","+5804125557788","1ra Avenida con calle 8, Buenos Aires, Argentina","juanpi@correo.com",true);
            Console.WriteLine("Nombre: " + c1.nom);
            Console.WriteLine("Telefono: " + c1.tlf);
            Console.WriteLine("Direccion: " + c1.dir);
            Console.WriteLine("Email: " + c1.mail);
            Console.WriteLine("Es un cliente nuevo?: {0}", c1.n ? "SI":"NO");
        }
    }

    public struct cliente
    {
        public cliente(string nombre, string telefono, string direccion, string email, bool nuevo)
        {
            nom  = nombre;
            tlf  = telefono;
            dir  = direccion;
            mail = email;
            n    = nuevo;
    }
        public string nom { get; }
        public string tlf { get; }
        public string dir { get; }
        public string mail { get; }
        public bool n { get; }
    }
}

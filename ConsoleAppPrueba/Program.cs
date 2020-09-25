using System;
using System.Collections;

namespace ConsoleAppPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Esto es un comentario
            Console.WriteLine("Hola mundo");
            //Modificacion directa en el servidor remoto
            Console.WriteLine("Adios");

            DateTime ahora = DateTime.Now;
            Console.WriteLine(ahora.ToLongDateString());
            Console.WriteLine("pruebaaaaaa");
            Console.WriteLine(ahora.ToLongTimeString());
            Console.WriteLine(ahora.ToString("dd/MM/yyyy hh:mm:ss"));
        }
    }
}

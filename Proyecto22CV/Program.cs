using Proyecto22CV.Clases;
using System;

namespace Proyecto22CV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acabas de clonar el repositorio!");
            Menu menu = new Menu();
            menu.Opciones();
        }
    }
}

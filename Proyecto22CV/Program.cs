using Proyecto22CV.Clases;
using Proyecto22CV.Funciones;
using System;

namespace Proyecto22CV
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.WriteLine("                                                ");
            Console.WriteLine("            B I E N V E N I D O S               ");
            Console.WriteLine("              V I D E O T E C A                 ");
            Console.WriteLine("                                                ");



            Console.WriteLine("   Inicia sesion o registrate por primera vez   ");
            Console.WriteLine("                                                ");
            Console.WriteLine("              1. INICIAR SESION                 ");
            Console.WriteLine("               2. REGISTRARSE                   ");
            Console.WriteLine("                                                ");


            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    CRUDUsuarios cRUDUsuarios = new CRUDUsuarios();
                    cRUDUsuarios.Login();
                    break;
                case 2:
                    Console.Clear();
                    CRUDUsuarios cRUDUsuarios1 = new CRUDUsuarios();
                    cRUDUsuarios1.Crear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("          ESCOGE UNA OPCION >:(                 ");
                    goto inicio;


            }
            Menu menu = new Menu();
            menu.Opciones();
        }
    }
}

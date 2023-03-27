using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22CV.Clases
{
    public class Menu
    {
        public void Opciones()
        {
        ERROR1:
            try
            {
                Console.WriteLine("Selecciona una opcion");
                Console.WriteLine("1. Peliculas");
                Console.WriteLine("2. Actores");
                Console.WriteLine("3. Directores");
                Console.WriteLine("4. Salir");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        opcionesPelicula();
                        goto ERROR1;
                    case 2:
                        Console.Clear();
                        opcionesActor();
                        goto ERROR1;
                    case 3:
                        Console.Clear();
                        opcionesDirector();
                        goto ERROR1;
                    case 4:
                        Console.WriteLine("ADIOS");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Escoja una opcion valida");
                        goto ERROR1;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Ingresa una opcion correcta");
                goto ERROR1;
            }

        }

        public void opcionesPelicula()
        {
        ERROR:
            Console.WriteLine("¿Que desea hacer?\n");
            Console.WriteLine("1. Leer");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    //instancie crud pelicula
                    Console.Clear();
                    goto ERROR;
                case 2:
                    Console.Clear();
                    goto ERROR;
                case 3:
                    Console.Clear();
                    goto ERROR;
                case 4:
                    Console.Clear();
                    goto ERROR;
                default:
                    Console.WriteLine("Escoja una opcion valida");
                    goto ERROR;
            }
        }

        public void opcionesActor()
        {
        ERROR:
            Console.WriteLine("¿Que desea hacer?\n");
            Console.WriteLine("1. Leer");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    //instancie crud Actores
                    Console.Clear();
                    goto ERROR;
                    break;
                case 2:
                    Console.Clear();
                    goto ERROR;
                    break;
                case 3:
                    Console.Clear();
                    goto ERROR;
                    break;
                case 4:
                    Console.Clear();
                    goto ERROR;
                    break;
                default:
                    Console.WriteLine("Escoja una opcion valida");
                    goto ERROR;
            }
        }

        public void opcionesDirector()
        {
        ERROR:
            Console.WriteLine("¿Que desea hacer?\n");
            Console.WriteLine("1. Leer");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    //instancie crud Directores
                    Console.Clear();
                    goto ERROR;
                case 2:
                    Console.Clear();
                    goto ERROR;
                case 3:
                    Console.Clear();
                    goto ERROR;
                case 4:
                    Console.Clear();
                    goto ERROR;
                default:
                    Console.WriteLine("Escoja una opcion valida");
                    goto ERROR;
            }
        }
    }
}

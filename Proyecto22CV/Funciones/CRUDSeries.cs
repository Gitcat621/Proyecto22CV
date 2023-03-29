using Proyecto22CV.Clases;
using Proyecto22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22CV.Funciones
{
    public class CRUDSeries
    {
        public void Crear()
        {

            using (var _context = new ApplicationDbContext())
            {
                Series series = new Series();
                {
                    Console.WriteLine("Ingrese el nombre de la serie:");
                    series.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la cantidad de temporadas:");
                    series.Temporadas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad de capitulos:");
                    series.Capitulos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del capitulo:");
                    series.NombreCap = Console.ReadLine();
                  
                };

                _context.Series.Add(series);
                _context.SaveChanges();

            }
        }

        public void Editar()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                Console.Clear();
                Console.WriteLine("Ingresa el numero o ID de la serie:");
                int id = int.Parse(Console.ReadLine());

                Series series = _context.Series.Find(id);

                Console.WriteLine("Ingrese el nuevo nombre de la serie");
                series.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo numero de Temporadas");
                series.Temporadas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de nuevos capitulo");
                series.Capitulos = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nuevo nombre del capitulo");
                series.NombreCap = Console.ReadLine();



                _context.Series.Update(series);
                _context.SaveChanges();
            }
        }

        public void Leer()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                var series = _context.Series.ToList();

                Console.WriteLine("--Lista de Series--");
                foreach (var item in series)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($">> Id: {item.Id}");
                    Console.WriteLine($">> Nombre: {item.Nombre}");
                    Console.WriteLine($">> Temporadas: {item.Temporadas}");
                    Console.WriteLine($">> Capitulos: {item.Capitulos}");
                    Console.WriteLine($">> NombreCap: {item.NombreCap}");
                    Console.WriteLine("_________________________________");


                }
            }
        }


        public void Eliminar()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Console.Clear();
                Console.WriteLine("Ingresa el numero o ID de pelicula:");
                int id = int.Parse(Console.ReadLine());

                var series = _context.Series.Find(id);

                _context.Series.Remove(series);
                _context.SaveChanges();

            }

        }
    }
}

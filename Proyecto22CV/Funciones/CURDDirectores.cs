using Proyecto22CV.Clases;
using Proyecto22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22CV.Funciones
{
    public class CURDDirectores
    {
        public void Crear()
        {

            using (var _context = new ApplicationDbContext())
            {
                    Directores director = new Directores();
                {

                    director.Nombre = Console.ReadLine();
                    director.Nacionalidad = Console.ReadLine();
                    director.PeliculaFamosa = Console.ReadLine();
                    director.DiaNacimiento = Console.ReadLine();
                    director.MesNacimiento = Console.ReadLine();
                    director.AñoNacimiento = Console.ReadLine();

                };

                _context.Directores.Add(director);
                _context.SaveChanges();

            }
        }

        public void Editar(int id)
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Directores director = _context.Directores.Find(id);

                director.Nombre = Console.ReadLine();
                director.Nacionalidad = Console.ReadLine();
                director.PeliculaFamosa = Console.ReadLine();
                director.DiaNacimiento = Console.ReadLine();
                director.MesNacimiento = Console.ReadLine();
                director.AñoNacimiento = Console.ReadLine();


                _context.Directores.Update(director);
                _context.SaveChanges();
            }
        }

        public void Leer()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                var director = _context.Directores.ToList();

                Console.WriteLine("--Lista de Director--");
                foreach (var item in director)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($">> Id: {item.Id}");
                    Console.WriteLine($">> Nombre: {item.Nombre}");
                    Console.WriteLine($">> Nacionalidad: {item.Nacionalidad}");
                    Console.WriteLine($">> Pelicula: {item.PeliculaFamosa}");
                    Console.WriteLine($">> DiaNacimiento: {item.DiaNacimiento}");
                    Console.WriteLine($">> MesNacimiento: {item.MesNacimiento}");
                    Console.WriteLine($">> AñoNacimiento: {item.AñoNacimiento}");
                    Console.WriteLine("_________________________________");


                }
            }
        }
    }
}

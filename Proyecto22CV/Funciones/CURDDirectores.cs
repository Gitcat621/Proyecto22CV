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
            Console.Clear();
            using (var _context = new ApplicationDbContext())
            {
                Directores director = new Directores();
                {
                    Console.WriteLine("Ingresa el nombre del director:");
                    director.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa la nacionalidad del director:");
                    director.Nacionalidad = Console.ReadLine();
                    Console.WriteLine("Ingresa la pelicula famosa del director:");
                    director.PeliculaFamosa = Console.ReadLine();
                    Console.WriteLine("Ingresa el dia de nacimiento del director:");
                    director.DiaNacimiento = Console.ReadLine();
                    Console.WriteLine("Ingresa el mes de nacimiento del director:");
                    director.MesNacimiento = Console.ReadLine();
                    Console.WriteLine("Ingresa el nombre del director:");
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
                Console.Clear();
                Directores director = _context.Directores.Find(id);

                Console.WriteLine("Actualice el nuevo nombre del director:");
                director.Nombre = Console.ReadLine();
                Console.WriteLine("Actualice la nueva nacionalidad del director:");
                director.Nacionalidad = Console.ReadLine();
                Console.WriteLine("Actualice la nueva pelicula famosa del director:");
                director.PeliculaFamosa = Console.ReadLine();
                Console.WriteLine("Actualice el dia de nacimiento del director:");
                director.DiaNacimiento = Console.ReadLine();
                Console.WriteLine("Actualice el mes de nacimiento del director:");
                director.MesNacimiento = Console.ReadLine();
                Console.WriteLine("Actualice el año de nacimiento del director:");
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

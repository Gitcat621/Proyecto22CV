using Proyecto22CV.Clases;
using Proyecto22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22CV.Funciones
{
    public class CRUDPeliculas
    {
        public void Crear()
        {

            using (var _context = new ApplicationDbContext())
            {
                Peliculas peliculas = new Peliculas();
       
                Console.WriteLine("Ingresa el nombre de la pelicula:");
                peliculas.Nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el año de la pelicula:");
                peliculas.Año = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la clasificacion de la pelicula:");
                peliculas.Clasificacion = Console.ReadLine();
                Console.WriteLine("Ingresa el director de la pelicula:");
                peliculas.Director = Console.ReadLine();
                Console.WriteLine("Ingresa la nacionalidad de la pelicula:");
                peliculas.Nacionalidad = Console.ReadLine();
                Console.WriteLine("Ingresa el genero de la pelicula:");
                peliculas.Genero = Console.ReadLine();
                Console.WriteLine("Ingresa el idioma de la pelicula");
                peliculas.Idioma = Console.ReadLine();
                Console.WriteLine("Ingresa la duracion de la pelicula");
                peliculas.Duracion = Console.ReadLine();


                //Console.WriteLine("Nombre de la pelicula" + peliculas.Nombre);
                //Console.WriteLine("Nombre de la pelicula" + peliculas.Año);
                //Console.WriteLine("Nombre de la pelicula" + peliculas.Clasificacion);
                //Console.WriteLine("Nombre de la pelicula" + peliculas.Director);
                //Console.WriteLine("Nombre de la pelicula" + peliculas.Nacionalidad);
                //Console.WriteLine("Nombre de la pelicula" + peliculas.Genero);
                //Console.WriteLine("Nombre de la pelicula" + peliculas.Idioma);
                //Console.WriteLine("Nombre de la pelicula" + peliculas.Duracion);


                _context.Peliculas.Add(peliculas);
                _context.SaveChanges();

            }

        }

        public void Editar()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Console.Clear();
                Console.WriteLine("Ingresa el numero o ID de pelicula:");
                int id = int.Parse(Console.ReadLine());

                Peliculas peliculas = _context.Peliculas.Find(id);

                Console.WriteLine("Actualiza el nombre del pelicula");
                peliculas.Nombre = Console.ReadLine();
                Console.WriteLine("Actualiza el año de la pelicula");
                peliculas.Año = int.Parse(Console.ReadLine());
                Console.WriteLine("Actualice la clasificacion de la pelicula");
                peliculas.Clasificacion = Console.ReadLine();
                Console.WriteLine("Actualice el nombre del director de la pelicula");
                peliculas.Director = Console.ReadLine();
                Console.WriteLine("Actualice la nacionalidad de la pelicula");
                peliculas.Nacionalidad = Console.ReadLine();
                Console.WriteLine("Actualice el genero de la pelicula");
                peliculas.Genero = Console.ReadLine();
                Console.WriteLine("Actualice el idioma de la pelicula");
                peliculas.Idioma = Console.ReadLine();
                Console.WriteLine("Actualice la duracion de la pelicula");
                peliculas.Duracion = Console.ReadLine();

                _context.Peliculas.Update(peliculas);
                _context.SaveChanges();
            }
        }

        public void Leer()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                var peliculas = _context.Peliculas.ToList();

                Console.WriteLine("--Lista de Peliculas--");
                foreach (var item in peliculas)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($">> Id: {item.Id}");
                    Console.WriteLine($">> Nombre: {item.Nombre}");
                    Console.WriteLine($">> Año: {item.Año}");
                    Console.WriteLine($">> Clasificacion: {item.Clasificacion}");
                    Console.WriteLine($">> Director: {item.Director}");
                    Console.WriteLine($">> Nacionalidad: {item.Nacionalidad}");
                    Console.WriteLine($">> Genero: {item.Genero}");
                    Console.WriteLine($">> Idioma: {item.Idioma}");
                    Console.WriteLine($">> Duracion: {item.Duracion}");
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

                var peliculas = _context.Peliculas.Find(id);

                _context.Peliculas.Remove(peliculas);
                _context.SaveChanges();

            }

        }
    }
}

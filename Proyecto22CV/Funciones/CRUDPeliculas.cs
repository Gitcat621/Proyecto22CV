﻿using Proyecto22CV.Clases;
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
                Peliculas peliculas = new Peliculas()
                {                   
                    Nombre = Console.ReadLine(),
                    Año = int.Parse(Console.ReadLine()),
                    Clasificacion = int.Parse(Console.ReadLine()),
                    Director = Console.ReadLine(),
                    Nacionalidad = Console.ReadLine(),
                    Genero = Console.ReadLine(),
                    Idioma = Console.ReadLine(),
                    Duracion = Console.ReadLine()
                };

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

        public void Editar(int id)
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Peliculas peliculas = _context.Peliculas.Find(id);

                peliculas.Nombre = Console.ReadLine();
                peliculas.Año = int.Parse(Console.ReadLine());
                peliculas.Clasificacion = int.Parse(Console.ReadLine());
                peliculas.Director = Console.ReadLine();
                peliculas.Nacionalidad = Console.ReadLine();
                peliculas.Genero = Console.ReadLine();
                peliculas.Idioma = Console.ReadLine();
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
    }
}

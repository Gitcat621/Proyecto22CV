using Proyecto22CV.Clases;
using Proyecto22CV.Context;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22CV.Funciones
{
    public class CRUD_Actores
    {
        public void Crear()
        {

            using (var _context = new ApplicationDbContext())
            {
                Actores actores = new Actores();
                {
                    Console.WriteLine("Ingrese el nombre del Actor");
                    actores.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la nacionalidad del Actor");
                    actores.Nacionalidad = Console.ReadLine();
                    Console.WriteLine("Ingrese el personaje famoso del Actor");
                    actores.PersonajeFamoso = Console.ReadLine();
                    Console.WriteLine("Ingrese la pelicula famosa del Actor");
                    actores.PeliculaFamosa = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el dia de nacimiento del Actor");
                    actores.DiaNacimiento = Console.ReadLine();
                    Console.WriteLine("Ingrese el mes del nacimiento del Actor");
                    actores.MesNacimiento = Console.ReadLine();
                    Console.WriteLine("Ingrese el año de nacimiento del Actor");
                    actores.Año = Console.ReadLine();

                };

                _context.Actores.Add(actores);
                _context.SaveChanges();

            }
        }

        public void Editar(int id)
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Actores actores = _context.Actores.Find(id);
                Console.WriteLine("Actualice el nombre del Actor");
                actores.Nombre = Console.ReadLine();
                Console.WriteLine("Actualice la nacionalidad del Actor");
                actores.Nacionalidad = Console.ReadLine();
                Console.WriteLine("Actualice su pesonaje famoso del Actor");
                actores.PersonajeFamoso = Console.ReadLine();
                Console.WriteLine("Actualice la pelicula mas famosa del Actor");
                actores.PeliculaFamosa = int.Parse(Console.ReadLine());
                Console.WriteLine("Actualice su dia de nacimiento del Actor");
                actores.DiaNacimiento = Console.ReadLine();
                Console.WriteLine("Actualice su mes de nacimiento del Actor");
                actores.MesNacimiento = Console.ReadLine();
                Console.WriteLine("Actualice el año de nacimiento del Actor");
                actores.Año = Console.ReadLine();

                _context.Actores.Update(actores);
                _context.SaveChanges();
            }
        }

        public void Leer()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                var actores = _context.Actores.ToList();

                Console.WriteLine("--Lista de Usuarios--");
                foreach (var item in actores)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($">> Id: {item.Id}");
                    Console.WriteLine($">> Nombre: {item.Nombre}");
                    Console.WriteLine($">> Nacionalidad: {item.Nacionalidad}");
                    Console.WriteLine($">> PersonajeFamoso: {item.PersonajeFamoso}");
                    Console.WriteLine($">> PeliculaFamosa: {item.PeliculaFamosa}");
                    Console.WriteLine($">> DiaNacimiento: {item.DiaNacimiento}");
                    Console.WriteLine($">> MesNacimiento: {item.MesNacimiento}");
                    Console.WriteLine($">> Año: {item.Año}");
                    Console.WriteLine("_________________________________");


                }
            }
        }


        public void Eliminar()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Console.Clear();
                Console.WriteLine("Ingresa el numero o ID de actor:");
                int id = int.Parse(Console.ReadLine());

                var actores = _context.Actores.Find(id);

                _context.Actores.Remove(actores);
                _context.SaveChanges();

            }

        }
    }
}

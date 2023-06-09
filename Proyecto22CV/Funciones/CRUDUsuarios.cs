﻿using Proyecto22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto22CV.Clases;

namespace Proyecto22CV.Funciones
{
    public class CRUDUsuarios
    {
        public void Crear()
        {

            using (var _context = new ApplicationDbContext())
            {
                Usuarios usuarios = new Usuarios();
                Console.WriteLine(" ~ R E G I S T R O   D E   U S U A R I O ~ ");
                Console.WriteLine("Ingresa tu username:");
                usuarios.User = Console.ReadLine();
                Console.WriteLine("Ingresa tu password:");
                usuarios.Password = Console.ReadLine();
                _context.Usuarios.Add(usuarios);
                _context.SaveChanges();

            }
        }

        public void Login()
        {
            Console.Clear();
            Console.WriteLine("Ingresa tu username:");
            string user = Console.ReadLine();

            Console.WriteLine("Ingresa tu password:");
            string password = Console.ReadLine();

            using (var _context = new ApplicationDbContext())
            {
                Usuarios usuario = _context.Usuarios.Where(x => x.Password == password && x.User == user).FirstOrDefault();

                if (usuario != null)
                {
                    Console.Clear();
                    Menu menu = new Menu();
                }
                else
                {
                    Console.WriteLine("USUARIO O PASSWORD INCORRECTO :(");
                }
            }
        }

        public void Editar(int id)
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Usuarios usuarios = _context.Usuarios.Find(id);

                usuarios.User = Console.ReadLine();
                usuarios.Password = Console.ReadLine();


                _context.Usuarios.Update(usuarios);
                _context.SaveChanges();
            }
        }

        public void Leer()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                var usuarios = _context.Usuarios.ToList();

                Console.WriteLine("--Lista de Usuarios--");
                foreach (var item in usuarios)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($">> Id: {item.Id}");
                    Console.WriteLine($">> Nombre: {item.User}");
                    Console.WriteLine($">> Año: {item.Password}");
                    Console.WriteLine("_________________________________");


                }
            }
        }
    }
}

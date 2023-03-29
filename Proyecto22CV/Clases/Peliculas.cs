using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22CV.Clases
{
    public class Peliculas
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Año { get; set; }
        public string Clasificacion { get; set; }
        public string Director { get; set; }
        public string Nacionalidad { get; set; }
        public string Genero { get; set; }
        public string Idioma { get; set; }
        public string Duracion { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22CV.Clases
{
    public class Series
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public int Temporadas { get; set; }
        public int Capitulos { get; set; }
        public string NombreCap { get; set; }

    }
}

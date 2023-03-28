using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22CV.Clases
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

    }    
}

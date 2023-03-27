using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22CV.Clases
{
    public class Directores
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public string PeliculaFamosa { get; set; }

        #region AtributosdeNacimiento
        //Atributos de la Fecha de nacimiento
        public string AñoNacimiento { get; set; }
        public string MesNacimiento { get; set; }
        public string DiaNacimiento { get; set; }
        #endregion
    }
}

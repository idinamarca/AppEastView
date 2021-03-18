using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEastView.Models
{
    public class Ciudadano
    {

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int EstadoCiudadano { get; set; }
    }
}

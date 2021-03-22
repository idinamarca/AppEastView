using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EastView.Core.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        public string CiudadanoId { get; set; }
        public Ciudadano Ciudadano { get; set; }
        public int TipoTareaId { get; set; }
        public TipoTarea TipoTarea { get; set; }
        public int EstadoTareaId { get; set; }
        public EstadoTarea EstadoTarea { get; set; }
        public int PrioridadTareaId { get; set; }
        public PrioridadTarea PrioridadTarea { get; set; }
        public int DiaTareaId { get; set; }
        public DiaTarea DiaTarea { get; set; }



    }
}

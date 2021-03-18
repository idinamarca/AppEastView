using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEastView.Models;

namespace AppEastView.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {

        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                using (ContextoDB db = new ContextoDB())
                {

                    var query = (from post in db.Tarea
                                join ciudadano in db.Ciudadano on post.CiudadanoId equals ciudadano.Id
                                join estadoTarea in db.EstadoTarea on post.EstadoTareaId equals estadoTarea.Id
                                join tipoTarea in db.TipoTarea on post.TipoTareaId equals tipoTarea.Id
                                join prioridadTarea in db.PrioridadTarea on post.PrioridadTareaId equals prioridadTarea.Id
                                join diatarea in db.DiaTarea on post.DiaTareaId equals diatarea.Id
                                select new 

                                {                                
                                    post,
                                    ciudadano.Id,
                                    ciudadano.Nombre,
                                    ciudadano.apellido,
                                    ciudadano.EstadoCiudadano,                                    
                                    estadoTarea.NombreTarea,
                                    tipoTarea.Tarea,
                                    prioridadTarea.Prioridad,
                                    diatarea.Dia                                 


                                }).ToList();


                                return new JsonResult(query.ToList());

                }               

            }

            catch (Exception ex)
            {
                Log.EscribeLog(ex);
                return new JsonResult("Ha ocurrido un error al obtener Ciudadanos.");
            }


        }



    }
}

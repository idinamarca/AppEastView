using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEastView.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace AppEastView.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadanoController : ControllerBase
    {
        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                using (ContextoDB db = new ContextoDB())
                {

                    IQueryable<Ciudadano> query = from s in db.Ciudadano
                                orderby s.FechaNacimiento
                                descending
                                select s; 

                  
                    return new JsonResult(query.ToList<Ciudadano>()); 
                }

            }

            catch (Exception ex)
            {
                Log.EscribeLog(ex);
                return new JsonResult("Ha ocurrido un error al obtener Ciudadanos.");
            }

           
        }




        [HttpPost]
        public JsonResult Post(Ciudadano ciudadano)
        {
            try
            {
                using (ContextoDB db = new ContextoDB())
                {

                    db.Add(ciudadano);
                    db.SaveChanges();
                    return new JsonResult("Se ingreso correctamente el ciudadano.");
                }

            }

            catch (Exception ex)
            {
                Log.EscribeLog(ex);
                return new JsonResult("Ha ocurrido un error al ingresar el Ciudadano.");
            }


        }


        [HttpPut]
        public JsonResult Put(Ciudadano ciudadano)
        {

            try
            {
                using (ContextoDB db = new ContextoDB())
                {
                    List<Ciudadano> lista = new List<Ciudadano>();

                    var query = from s in db.Ciudadano where s.Id == ciudadano.Id select s;

                    Ciudadano dciudadano = query.First<Ciudadano>();

                    dciudadano.Nombre = ciudadano.Nombre;
                    dciudadano.apellido = ciudadano.apellido;
                    dciudadano.EstadoCiudadano = ciudadano.EstadoCiudadano;
                    db.SaveChanges();

                    return new JsonResult("Actualizacion realizada.");
                }
              
            }
            catch (Exception ex)
            {
                Log.EscribeLog(ex);
                return new JsonResult("Ha ocurrido un error al actualizar el Ciudadano.");
            }

        }


        [HttpDelete("{idCiudadano}")]
        public JsonResult Delete(string idCiudadano)
        {

            try
            {
                using (ContextoDB db = new ContextoDB())
                {
                    var ciudadanodelete =
                        from c in db.Ciudadano
                        where c.Id == idCiudadano
                        select c;


                    foreach (var delCiuda in ciudadanodelete)
                    {

                        db.Ciudadano.Remove(delCiuda);
                    }

                    return new JsonResult("Ciudadano Eliminado.");

                }

            }

            
            catch (Exception ex)
            {
                Log.EscribeLog(ex);
                return new JsonResult("Ha ocurrido un error al eliminar el Ciudadano.");
            }


        }

    }

}

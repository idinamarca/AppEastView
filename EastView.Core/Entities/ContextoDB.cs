using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEastView.Models;
using System.Data;
namespace EastView.Core.Entities
{
    public class ContextoDB : DbContext
    {

        public DbSet<Ciudadano> Ciudadano { get; set; }
        public DbSet<DiaTarea> DiaTarea { get; set; }
        public DbSet<EstadoTarea> EstadoTarea { get; set; }
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<PrioridadTarea> PrioridadTarea { get; set; }
        public DbSet<TipoTarea> TipoTarea { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IG6LSQA\SQLEXPRESS;Database=BDEastview;Integrated Security=true;");
        }

        //public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        //{ }

    }

   
}

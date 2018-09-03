using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class Promedio
    {
        public string id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Nota { get; set; }
        public string materia { get; set; }

    }

    public class promedioDBcontext : DbContext
    {
        public DbSet<Promedio> Promedios { get; set; }
    }
}
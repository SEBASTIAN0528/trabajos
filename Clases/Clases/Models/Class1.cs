using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clases.Models
{
    public class Class1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ODI { get; set; }
        public int Test { get; set; }
    }

    public class CricketerDBContext : DbContext
    {
        public DbSet<Cricketer> Cricketers { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppConversion.Models
{
    public class Convertidor
    {
        public int Id { get; set; }
        public string Num { get; set; }
        public string NumeroString { get; set; }
    }
    public class NumberContext : DbContext
    {
        public DbSet<Convertidor> Numero { get; set; }
    }
}
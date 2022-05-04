using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace naman11.Models
{
    public class Applicationdbcontext:DbContext
    {
        public Applicationdbcontext() :
            base("Data Source=CHETUIWK1144\\SQLSERVER;Initial Catalog=lavig2;Integrated Security=True;Pooling=False") { }


        public DbSet<post> post { get; set; }
        public DbSet<employess> employess { get; set; }
    }
}
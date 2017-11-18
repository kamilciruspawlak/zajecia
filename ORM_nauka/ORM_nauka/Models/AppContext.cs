using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ORM_nauka.Models
{
    public class AppContext : DbContext

    {
        public AppContext() : base("TestDB")
        {

        }
        public DbSet<TestDBmodel> TestDBmodels { get; set; }
        //public DbSet<Car> Cars { get; set; }
        //public DbSet<Owner> Owners { get; set; }
 

    }
}
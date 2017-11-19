using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace samochodziki.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("SamochodyDB")
        {

        }
        public DbSet<TestDBModel> TestDBModels { get; set; }
    }
}
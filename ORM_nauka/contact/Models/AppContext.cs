using contact.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace contact.Models
{
    public class AppContext : DbContext

    {
        public AppContext() : base("ContectDB")
        {
            
        }
        public DbSet<TestDBModel> TestDBModels { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace shoping_list.Models
{
    public class AppContext : DbContext

    {
        public AppContext() : base("ShopingListDB")
        {

        }
        public DbSet<TestDBmodel> TestDBmodels { get; set; }
    }
}
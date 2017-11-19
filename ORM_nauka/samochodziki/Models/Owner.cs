using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace samochodziki.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Car> CarsList { get; set; }
    }
}
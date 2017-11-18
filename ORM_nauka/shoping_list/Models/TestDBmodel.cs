using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shoping_list.Models
{
    public class TestDBmodel
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Ilosc { get; set; }
        public DateTime Data { get; set; }
        public DateTime OstatniaModyfikacja { get; set; }
    }
}
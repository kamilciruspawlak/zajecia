using Fuel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fuel.ViewModel
{
    public class FuelViewModel
    {
        public FuelModel FuelModel  { get; set; }
        public bool ShowResult { get; set; }
    }
}
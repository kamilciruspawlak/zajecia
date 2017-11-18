using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fuel.BusinessLogic
{
    public class FuelBusinessLogic
    {
        public double CalculateAvgConsump(int fuel, int distance)
        {
            double avg = ((double) fuel / distance)*100;
            return avg;
        }
    }
}
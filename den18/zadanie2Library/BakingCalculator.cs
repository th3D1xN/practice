using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2Library
{
    public static class BakingCalculator
    {
        public static int AdjustBakingTime(Bread bread, double ovenTemperature)
        {
            double standardTemp = 200;
            double adjustmentFactor = standardTemp / ovenTemperature;
            return (int)(bread.BakingTime * adjustmentFactor);
        }
    }
}

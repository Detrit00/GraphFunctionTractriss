using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractrixNamespace
{
    public class TractrixClass
    {
        public static double EquationTractrix(double a ,double y)
        {
            double rootNumber = Math.Sqrt((Math.Pow(a, 2) - Math.Pow(y, 2)));
            double x = (a * Math.Log(((a + rootNumber) / y), Math.E)) - rootNumber;
            return Math.Round(x, 3);
        }
        
    }
}

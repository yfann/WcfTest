using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
namespace Services
{
    public class Servicescs:ICalculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}

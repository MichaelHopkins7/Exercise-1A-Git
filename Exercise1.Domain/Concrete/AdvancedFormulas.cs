#region System namespaces
using System;
using System.Collections.Generic;
#endregion

#region Solution namespaces
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Domain.Concrete
{
    public class AdvancedFormulas : IAdvancedFormulas
    {
        public double[] QuadraticEquation(double a, double b, double c)
        {
            // TODO - 5 - Calculate real results for the quadratic equation
            double[] Solution = new double[2];
            double b4ac = b * b - 4 * a * c;
            Solution[0] = (-b + Math.Sqrt(b4ac)) / (2 * a);
            Solution[1] = (-b - Math.Sqrt(b4ac)) / (2 * a);
            return Solution;
        }
    }
}

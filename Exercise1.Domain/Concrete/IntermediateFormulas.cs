#region System namespaces
using System;
#endregion

#region Solution namespaces
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Domain.Concrete
{
    public class IntermediateFormulas : IIntermediateFormulas
    {
        public double AreaOfTriangle(double a, double b, double c)
        {
            // TODO - 4 - Calculate the area of a triangle using Heron's formula
            double HalfCOfT; //Making variable for triangle circumference / 2
            HalfCOfT = (a + b + c) / 2;
            return Math.Sqrt(HalfCOfT * (HalfCOfT - a) * (HalfCOfT - b) * (HalfCOfT - c));
        }
    }
}

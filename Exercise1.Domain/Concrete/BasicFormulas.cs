#region System namespaces
using System;
#endregion

#region Solution namespaces
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Domain.Concrete
{
    public class BasicFormulas : IBasicFormulas
    {
        public double CircumferenceOfCircle(double radius)
        {
            // TODO - 1 - Calculate the circumference of a circle
            return 2 * Math.PI * radius;
        }

        public double AreaOfCircle(double radius)
        {
            // TODO - 2 - Calculate the area of a circle
            return Math.PI * radius * radius;
        }

        public double VolumeOfHemisphere(double radius)
        {
            // TODO - 3 - Calculate the volume of a hemisphere
            return ((4.0 / 3) * Math.PI * radius * radius * radius) / 2;
        }
    }
}

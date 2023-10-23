using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_GrundernaOOP
{
    internal class Circle
    {
        private double _radius;

        public double Radius
        {
            get => _radius; 
            set => _radius = value;
        }

        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public double GetSphereVolume()
        {
            return (4 / 3) * Math.PI * (Radius * Radius * Radius);
        }
    }
}

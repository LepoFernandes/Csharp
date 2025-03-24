using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto169.Entities.Enums;


namespace Projeto169.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Colores color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}

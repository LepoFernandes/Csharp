using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto169.Entities.Enums;

namespace Projeto169.Entities
{
    abstract class Shape
    {
        public Colores Color { get; set; }

        public Shape(Colores color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}

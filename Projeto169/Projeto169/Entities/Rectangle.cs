﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto169.Entities.Enums;

namespace Projeto169.Entities
{
    class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }
        
        public Rectangle(double width, double height ,Colores color) : base(color) 
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}

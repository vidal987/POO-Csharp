using ExecInterface2.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExecInterface2.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;


   public abstract class GeometricFigure
    {
    protected GeometricFigure(string name)
    {
        Name = name;
    }

    public string Name { get; set; }  = null!;

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-20} => Area......: {GetArea(),12:F5} Perimeter: {GetPerimeter(),12:F5}";
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;

public class Circle : GeometricFigure
{
    private double _r;
    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    public double R { get => _r; set => _r = ValidateR(value); }

    public override string ToString()
    {
        return base.ToString();
    }

    public override double GetArea()
    {
        return Math.PI * R * R; ;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }

    private double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentException("El radio debe ser positivo.");
        }
        return r;
    }
}


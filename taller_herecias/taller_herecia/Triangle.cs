using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    public double C { get => _c; set => _c = ValidateC(value); }
    public double H { get => _h; set => _h = ValidateH(value); }

    public override string ToString()
    {
        return base.ToString();
    }

    public override double GetArea()
    {
        return (B * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C ;
    }

    private double ValidateC(double c)
    {
        if (c <= 0)
        {
            throw new ArgumentException("La diagonal 1 debe ser positivaa.");
        }
        return c;
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("La diagonal 2 debe ser positiva.");
        }
        return h;
    }
}

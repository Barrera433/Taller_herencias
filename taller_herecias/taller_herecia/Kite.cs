﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;
public class Kite : Rhombus
{
    private double _b;

    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
    {
        B = b;
    }

    public double B { get => _b; set => _b = ValidateB(value); }

    public override string ToString()
    {
        return base.ToString();
    }

    public override double GetArea()
    {
        return (D1*D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new ArgumentException("El lado B debe ser positivo.");
        }
        return b;
    }
}

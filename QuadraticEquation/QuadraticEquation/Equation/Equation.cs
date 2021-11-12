using System;

namespace QuadraticEquation
{
    public class Equation
    {
        public Equation() { }

        public Equation(double a, double b, double c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Equation equation &&
                   a == equation.a &&
                   b == equation.b &&
                   c == equation.c;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(a, b, c);
        }
    }
}
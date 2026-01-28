using ExerciceFigures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceFigures.Classes
{
    internal class Point : IDeplacable
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X};{Y}";
        }

        public void Deplacement(double x, double y)
        {
            X += x;
            Y += y;
        }
    }
}

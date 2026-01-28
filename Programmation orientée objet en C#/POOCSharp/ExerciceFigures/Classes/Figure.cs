using ExerciceFigures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceFigures.Classes
{
    internal class Figure : IDeplacable
    {
        public Point Origin { get; protected set; } = new Point();
        //public Point A => Origin;
        public Point A { get => Origin; protected set => Origin = value; }

        protected Figure() { }
        protected Figure(Point origin)
        {
            Origin = origin;
        }

        protected Figure(double x, double y)
        {
            Origin = new Point(x, y);
        }

        public virtual void Deplacement(double x, double y)
        {
            //A.X += x;
            //A.Y += y;
            Origin.Deplacement(x, y);
        }
    }
}

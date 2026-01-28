using DemoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInterface.Classes
{
    internal class Poisson : Animal, INageant
    {
        public void Nager()
        {
            Console.WriteLine("Le poisson nage");
        }
    }
}

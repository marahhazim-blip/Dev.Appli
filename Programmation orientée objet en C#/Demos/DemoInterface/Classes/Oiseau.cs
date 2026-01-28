using DemoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInterface.Classes
{
    internal class Oiseau : Animal, IVolant
    {
        public void Atterir()
        {
            Console.WriteLine("L'oiseau atterrit");
        }

        public void SEnvoler()
        {
            Console.WriteLine("L'oiseau s'envole");
        }
    }
}

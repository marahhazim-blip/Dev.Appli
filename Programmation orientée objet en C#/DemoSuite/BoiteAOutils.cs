using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPOOSuite
{
    internal class BoiteAOutils
    {

        public static int Addition(int nbr1,int nbr2)
        {
            return nbr1 + nbr2; 
        }

        public static void MessageBienvenue(string name)
        {
            Console.WriteLine("###########################");
            Console.WriteLine($"Bienvenue dans notre programme mon cher {name}");
            Console.WriteLine("###########################");
        }
    }
}

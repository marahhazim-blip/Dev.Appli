using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2.Classes
{
    // Bonus Exercice 2
    internal class OrderUtils
    {

        public static bool IsValidCustomerName(string name)
        {
            if (name is null)
            {
                return false;
            }

            name = name.Trim();
            return name.Length >= 2;
        }

        public static string NormalizeCustomerName(string name)
        {
            if (name is null)
            {
                return "";
            }

            name = name.Trim();

            string lower = name.ToLowerInvariant(); // mise en minuscule du name recu
            return char.ToUpperInvariant(lower[0]) + lower.Substring(1); // passage de la premiere lettre en majuscule et conatenation avec le reste du nom en minuscule
        }
    }
}

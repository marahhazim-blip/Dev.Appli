using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2.Classes
{
    internal class Order
    {
        // Auto-property
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public bool IsCancelled { get; set; }

        // Attributs static
        private static int createdOrdersCount = 0;
        private static int cancelledOrdersCount = 0;
        private static decimal totalAmountCreated = 0;

        public Order(string customerName, decimal amount)
        {
            CustomerName = customerName;
            Amount = amount;
            IsCancelled = false;

            createdOrdersCount++; // je compte une commande en plus
            totalAmountCreated += amount; // j'ajoute le montant de cette nouvelle commande au montant total de toutes les commandes

        }

        public void Cancel ()
        {
            IsCancelled = true;
            cancelledOrdersCount++;
            totalAmountCreated -= Amount;
        }

        public static void InfosCommandes()
        {
            Console.WriteLine("#######  Infos sur les commandes :  #######");
            Console.WriteLine($"Nombre de commandes passe : {createdOrdersCount}"); 
            Console.WriteLine($"Montant de toutes les commandes recu : {totalAmountCreated}");
            Console.WriteLine($"Nombre de commandes annule : {cancelledOrdersCount}");
            Console.WriteLine("###########################################");
        }



    }
}

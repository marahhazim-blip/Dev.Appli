using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceCompteBancaire.Classes
{
    internal class Operation
    {
        public int Numero { get; set; }
        public decimal Montant { get; set; }
        public string StatutOperation { get; set; }
        public Operation(int numero, decimal montant, string statutOperation)
        {
            Numero = numero;
            Montant = montant;
            StatutOperation = statutOperation;
        }

        public override string? ToString()
        {
            return $"Numero = {Numero}, Montant = {Montant}, StatutOperation = {StatutOperation}";
        }
    }
}

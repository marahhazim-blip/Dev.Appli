using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceSalarieHeritage.Classes
{
    internal class Commercial : Salarie
    {
        public decimal ChiffreDAffaire { get; set; } = 0;
        public decimal CommissionPct { get; set; } = 0;
        public override decimal SalaireTotal => Salaire + (ChiffreDAffaire * CommissionPct / 100);

        public Commercial() : base()
        {
            Nom = "Commercial par défaut";
        }

        public Commercial(decimal chiffreDAffaire, decimal commissionPct,
            int salaire, string matricule, string service, string categorie, string nom)
            : base(salaire, matricule, service, categorie, nom)
        {
            ChiffreDAffaire = chiffreDAffaire;
            CommissionPct = commissionPct;
        }

        public override void AfficherSalaire()
        {
            base.AfficherSalaire();
            Console.WriteLine($"Le salaire avec commission {SalaireTotal} euros");
        }

        public override string ToString()
        {
            return $"{Nom}, Chiffre d'affaire = {ChiffreDAffaire}, Commission = {CommissionPct} %";
        }
    }
}

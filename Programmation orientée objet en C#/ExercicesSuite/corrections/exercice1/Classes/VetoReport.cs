using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1.Classes
{
    internal class VetoReport
    {
        private string animalName;
        private string notes;
        private int severity;

        public VetoReport()
        {
            animalName = "Unknown";
            notes = "";
            severity = 1;
        }

        public string GetAnimalName()
        {
            return animalName;
        }

        public void SetAnimalName(string value)
        {
            animalName = value;
        }

        public string GetNotes()
        {
            return notes;
        }

        public void SetNotes(string value)
        {
            notes = value;
        }

        public int GetSeverity()
        {
            return severity;
        }

        public bool SetSeverity(int value)
        {
            if (value < 1 || value > 5)
            {
                return false;
            }

            severity = value;
            return true;
        }

        public void Print()
        {
            Console.WriteLine("Veto Report");
            Console.WriteLine($"  Animal   : {animalName}");
            Console.WriteLine($"  Severity : {severity}/5");
            Console.WriteLine($"  Notes    : {notes}");
        }
    }
}

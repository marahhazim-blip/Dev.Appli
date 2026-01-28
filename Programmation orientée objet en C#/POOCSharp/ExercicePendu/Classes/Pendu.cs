using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicePendu.Classes
{
    internal class Pendu
    {

        private string _masque = "";
        private int _nbEssaisTotal = 10;
        private int _nbEssaisRestants;
        private string _motATrrouver;
        private string _lettresTestes = "";

        public string Masque { get => _masque; }
        public int NbEssaisTotal { get => _nbEssaisTotal; }
        public int NbEssaisRestants { get => _nbEssaisRestants; }


        public Pendu(string motATrrouver)
        {
            this._motATrrouver = motATrrouver;
            _nbEssaisRestants = _nbEssaisTotal;
            this.GenererMasque();
        }

        public Pendu(string motATrrouver,int nbEssais)
        {
            this._nbEssaisTotal = nbEssais;
            this._motATrrouver = motATrrouver;
            _nbEssaisRestants = nbEssais;
            this.GenererMasque();
        }

        public void GenererMasque()
        {
            _masque = "";
            foreach(char lettre in _motATrrouver)
            {
                if(_lettresTestes.Contains(lettre))
                {
                    _masque += lettre;
                }else
                {
                    _masque += "*";
                }
                   
            }

        }

        public void TestChar(char lettre)
        {
            this._lettresTestes += lettre;
            if (this._motATrrouver.Contains(lettre))
            {
                Console.WriteLine("Lettre Correct");
                GenererMasque();
            }else
            {
                Console.WriteLine("Lettre Incorrect");
                _nbEssaisRestants--;
            }
        }


        public bool TestWin()
        {
            if (_masque.Contains("*"))
            {
                return false;
            }
            return true;
        }




    }
}

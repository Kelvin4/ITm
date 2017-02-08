using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _ITmaintenance
{
    class Fehler
    {
        //Unterstützungsfeld
        private string fehlertyp;
        private double fehlerpreis;
        private long fehlercode;

        //Konstruktor
        public Fehler(string fehlertyp, double fehlerpreis, long fehlercode)
        {
            this.fehlertyp = fehlertyp;
            this.fehlerpreis = fehlerpreis;
            this.fehlercode = fehlercode;
        }

        //Eingenschaften
        public string Fehlertyp
        {
            get { return this.fehlertyp; }
        }

        public double Fehlerpreis
        {
            get { return this.fehlerpreis; }
        }

        public long Fehlercode
        {
            get { return this.fehlercode; }
        }
    }
}

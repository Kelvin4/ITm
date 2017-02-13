using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _ITmaintenance
{
    class Fehler
    {

        private string fehlertyp;
        private double fehlerpreis;
        private long fehlercode;

        public Fehler(string fehlertyp, double fehlerpreis, long fehlercode)
        {
            this.fehlertyp = fehlertyp;
            this.fehlerpreis = fehlerpreis;
            this.fehlercode = fehlercode;
        }

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

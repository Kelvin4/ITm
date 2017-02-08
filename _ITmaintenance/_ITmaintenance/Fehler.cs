using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _ITmaintenance
{
    class Fehler
    {
<<<<<<< HEAD
        //Unterstützungsfeld
        /// <summary>
        /// 
=======
        /// <summary>
        /// Unterstützungsfeld
>>>>>>> master
        /// </summary>
        private string fehlertyp;
        private double fehlerpreis;
        private long fehlercode;

<<<<<<< HEAD
        //Konstruktor
        /// <summary>
        /// 
=======
        /// <summary>
        /// Konstruktor
>>>>>>> master
        /// </summary>
        /// <param name="fehlertyp"></param>
        /// <param name="fehlerpreis"></param>
        /// <param name="fehlercode"></param>
        public Fehler(string fehlertyp, double fehlerpreis, long fehlercode)
        {
            this.fehlertyp = fehlertyp;
            this.fehlerpreis = fehlerpreis;
            this.fehlercode = fehlercode;
        }

<<<<<<< HEAD
        //Eingenschaften
        /// <summary>
        /// 
=======
        /// <summary>
        /// Eingenschaften
>>>>>>> master
        /// </summary>
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

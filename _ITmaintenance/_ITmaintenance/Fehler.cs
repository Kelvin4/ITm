﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _ITmaintenance
{
    class Fehler
    {
        /// <summary>
        /// Unterstützungsfeld
        /// </summary>
        private string fehlertyp;
        private double fehlerpreis;
        private long fehlercode;

        /// <summary>
        /// Konstruktor
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

        /// <summary>
        /// Eingenschaften
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

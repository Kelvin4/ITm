using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _ITmaintenance
{
    class Besitzer
    {
        /// <summary>
        /// Unterstützungsfelder
        /// </summary>
        private string name, vorname, postleitzahl, ort, handynummer;
        private char strasse, email;
        private int hausnummer;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="vorname"></param>
        /// <param name="postleitzahl"></param>
        /// <param name="ort"></param>
        /// <param name="handynummer"></param>
        /// <param name="strasse"></param>
        /// <param name="email"></param>
        /// <param name="hausnummer"></param>
        public Besitzer(string name, string vorname, string postleitzahl, string ort, string handynummer, char strasse, char email, int hausnummer)
        {
            this.name = name;
            this.vorname = vorname;
            this.postleitzahl = postleitzahl;
            this.ort = ort;
            this.handynummer = handynummer;
            this.strasse = strasse;
            this.email = email;
            this.hausnummer = hausnummer;
        }


        /// <summary>
        /// Eingenschaften
        /// </summary>
        public string Name
        {
            get{return this.name;}
        }

        public string Vorname
        {
            get { return this.vorname; }
        }

        public string Postleitzahl
        {
            get { return this.vorname; }
        }

        public string Ort
        {
            get { return this.ort; }
        }

        public string Handynummer
        {
            get { return this.handynummer; }
        }

        public char Strasse        {
            get { return this.strasse; }
        }

        public char Email
        {
            get { return this.email; }
        }

        public int Hausnummer
        {
            get { return this.hausnummer; }
        }
    }
}

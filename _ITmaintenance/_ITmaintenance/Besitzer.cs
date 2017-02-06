using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _ITmaintenance
{
    class Besitzer
    {
        private string name, vorname, postleitzahl, ort, handynummer;
        private char strasse, email;
        private int hausnummer;

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

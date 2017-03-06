using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _ITmaintenance
{
    class Elektrogeraet
    {
        /// <summary>
        /// Unterstützungsfelder
        /// </summary>
        private Besitzer besitzer;
        private string id, geraetTyp, geraetName, productID;
        private Enum status;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="besitzer"></param>
        /// <param name="geraetTyp"></param>
        /// <param name="geraetName"></param>
        /// <param name="productID"></param>
        /// <param name="Status"></param>
        public Elektrogeraet(string id, string geraetTyp, Besitzer besitzer, string geraetName, string productID, Enum status)
        {
            this.id = id;
            this.geraetTyp = geraetTyp;
            this.besitzer = besitzer;
            this.geraetName = geraetName;
            this.productID = productID;
            this.status = status;
        }

        /// <summary>
        /// Eingenschaften
        /// </summary>
        public string ID
        {
            get { return this.id; }
        }
        public string GeraetTyp
        {
            get { return this.geraetTyp; }
        }

        public Besitzer Besitzer
        {
            get { return this.besitzer; }
        }

        public string GeraetName
        {
            get { return this.geraetName; }
        }

        public string ProductID
        {
            get { return this.productID; }
        }

        public Enum STATUS
        {
            get { return this.status; }
        }

        public string output()
        {
            string output = "ID: " + this.id + "\n" +
                    "Gerätename: " + this.geraetName;
            return output;

        }
    }
}

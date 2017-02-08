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
        private string geraetName, productID;
        private Enum Status;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="besitzer"></param>
        /// <param name="geraetName"></param>
        /// <param name="productID"></param>
        /// <param name="Status"></param>
        public Elektrogeraet(Besitzer besitzer, string geraetName, string productID, Enum Status)
        {
            this.besitzer = besitzer;
            this.geraetName = geraetName;
            this.productID = productID;
            this.Status = Status;
        }

        /// <summary>
        /// Eingenschaften
        /// </summary>
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
            get { return this.Status; }
        }
    }
}

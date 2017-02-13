using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ITmaintenance
{
    /// <summary>
    /// Diese Klasse arbeitet als Codierer und Decodierer
    /// </summary>
    class Coder
    {
        /// <summary>
        /// Konstruktor des Coders
        /// </summary>
        public Coder()
        {

        }

        /// <summary>
        /// Entschlüsselungsmethode
        /// </summary>
        /// <param name="input">verschlüsseltes Passwort</param>
        /// <returns>entschlüsseltes Passwort</returns>
        public char[] Decrypt(char[] input)
        {
            //Länge des Passworts
            int length = input.Length;
            //Abschneiden des letzten Zeichens
            input [length - 1] = '\0';
            return input;
        }

        /// <summary>
        /// Verschlüsselungsmethode
        /// </summary>
        /// <param name="input">unverschlüsseltes Passwort</param>
        /// <returns>verschlüsseltes Passwort</returns>
        public char[] Encrypt(char[] input)
        {
            //Konvertierung in einen String
            string strPassword = new string(input);
            //Eigentliche Kodierung
            char[] cryptPassword = (strPassword + "_").ToCharArray();
            return cryptPassword;
        }
    }
}

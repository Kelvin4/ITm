using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ITmaintenance
{
    class Benutzer
    {
        private static Benutzer benutzer = new Benutzer();
        private string name;
        private char[] password;

        private Benutzer()
        {

        }

        public static Benutzer getInstance()
        {
            return benutzer;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set { }
        }

        public char[] Password
        {
            get
            {
                return this.password;
            }
            private set { }
        }

        public void setData(string name, char[] password)
        {
            this.name = name;
            this.password = password;
        }
    }
}

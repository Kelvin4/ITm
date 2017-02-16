using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace _ITmaintenance
{
    /// <summary>
    /// Diese Klasse erstellt die Verbindung zur Datenbank
    /// </summary>
    class Login_SQL_Adapter
    {

        /// <summary>
        /// Name der Datenbank
        /// </summary>
        private string dataSource;

        /// <summary>
        /// Name aus der Textbox
        /// </summary>
        private string name;

        /// <summary>
        /// eingegebenes Passwort
        /// </summary>
        private char[] password;

        /// <summary>
        /// Passwort aus der Datenbank
        /// </summary>
        private char[] passwordDatabase;

        /// <summary>
        /// Personalnummer des Mitarbeiters
        /// </summary>
        private int personalnummer;

        /// <summary>
        /// SQL - Verbindung
        /// </summary>
        private SQLiteConnection connection;

        /// <summary>
        /// SQL - Commando
        /// </summary>
        private SQLiteCommand command;

        /// <summary>
        /// 
        /// </summary>
        private SQLiteDataReader reader;

        private Coder coder;

        /// <summary>
        /// Konstruktor des Adapters
        /// </summary>
        /// <param name="name">Eingabe des zu überprüfendes Namens</param>
        /// <param name="password">Eingabe des zu überprüfendes Passworts</param>
        public Login_SQL_Adapter(string name, char[] password)
        {
            //dynamische und statische Zuweisung
            this.name               = name;
            this.password           = password;
            this.passwordDatabase   = "".ToCharArray();
            this.personalnummer     = 0;
            this.dataSource         = "Mitarbeiter.sqlite";
            this.connection         = new SQLiteConnection();
            this.coder              = new Coder();
            //Initialisierung des Adapters
            this.initSQLAdapter();
        }

        /// <summary>
        /// Initialisiert die Verbindung und führt das Querie aus
        /// </summary>
        /// <returns>kein Rückgabewert</returns>
        private void initSQLAdapter()
        {
            //Zuweisung der Datenbank
            this.connection.ConnectionString = "Data Source=" + this.dataSource;
            //Öffnen der Verbindung
            connection.Open();
            //Zuweisung der Datenbank an das Command
            this.command = new SQLiteCommand(this.connection);
            //Querie - Text
            this.command.CommandText = "SELECT Personalnummer, Passwort FROM Mitarbeiter WHERE Name = '" + this.name + "'";
            // Ausführung des Queries
            this.command.ExecuteNonQuery();
            this.reader = this.command.ExecuteReader();
            //Abfragen des Readers
            while (reader.Read())
            {
                //Abfrage der Personalnummer
                this.personalnummer     = reader.GetInt32(reader.GetOrdinal("Personalnummer"));
                Console.WriteLine(this.personalnummer);
                //Abfrage des Passworts
                this.passwordDatabase   = reader.GetString(reader.GetOrdinal("Passwort")).ToCharArray();
            }
            this.connection.Close();
        }

        /// <summary>
        /// Diese Methode überprüft die Daten
        /// </summary>
        /// <returns></returns>
        public bool CheckUser()
        {
            //Speichervariable
            bool validUser = false;

            //Entschlüsseltes Passwort
            char[] encryptPassword = coder.Decrypt(this.passwordDatabase);

            //Überprüfung der Werte
            if( encryptPassword.SequenceEqual(this.password))
            {
                //True
                validUser = true;
            }
            else
            {
                //False
                validUser = false;
            }

            return validUser;
        }

        /// <summary>
        /// Getter für die Personalnummer
        /// </summary>
        /// <returns>gibt Personalnummer zurück</returns>
        public int getPersNr()
        {
            return this.personalnummer;
        }
    }
}

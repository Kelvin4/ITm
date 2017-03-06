using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _ITmaintenance
{
    class Aendern_SQL_Adapter
    {
        /// <summary>
        /// Name der Datenbank
        /// </summary>
        private string dataSource;

        private string name;

        /// <summary>
        /// eingegebenes Passwort
        /// </summary>
        private char[] passwordOld;

        /// <summary>
        /// eingegebenes Passwort
        /// </summary>
        private char[] passwordNew;

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


        /// <summary>
        /// Konstruktor des Adapters
        /// </summary>
        /// <param name="name">Eingabe des zu überprüfendes Namens</param>
        /// <param name="password">Eingabe des zu überprüfendes Passworts</param>
        public Aendern_SQL_Adapter(string name, char[] passwordOld, char[] passwordNew)
        {
            //dynamische und statische Zuweisung
            this.dataSource = "Mitarbeiter.sqlite";
            this.name = name;
            this.passwordOld = passwordOld;
            this.passwordNew = passwordNew;
            this.connection = new SQLiteConnection();
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
            this.command.CommandText = "Update Mitarbeiter SET Passwort = '" + this.passwordNew + "' WHERE Name = '" + this.name + "' AND Passwort = '" + this.passwordOld + "'";
            // Ausführung des Queries
            this.command.ExecuteNonQuery();
            this.reader = this.command.ExecuteReader();
        
        }
    }
}

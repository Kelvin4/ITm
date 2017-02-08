using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace _ITmaintenance
{
    class Login_SQL_Adapter
    {

        /// <summary>
        /// 
        /// 
        /// </summary>
        private string dataSource;

        /// <summary>
        /// 
        /// 
        /// </summary>
        private string name;

        /// <summary>
        /// 
        /// </summary>
        private char[] password;

        /// <summary>
        /// 
        /// </summary>
        private SQLiteConnection verbindung = new SQLiteConnection();

        /// <summary>
        /// 
        /// </summary>
        private SQLiteConnection connection;

        /// <summary>
        /// 
        /// </summary>
        private SQLiteCommand command;

        /// <summary>
        /// 
        /// </summary>
        private SQLiteDataReader reader;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public Login_SQL_Adapter(string name, char[] password)
        {
            this.name       = name;
            this.password   = password;
            this.dataSource = "Mitarbeiter.sqlite";
            this.connection = new SQLiteConnection();
            this.CheckDatabase();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void CheckDatabase()
        {
            this.connection.ConnectionString = "Data Source=" + this.dataSource;
            connection.Open();
            this.command = new SQLiteCommand(this.connection);
            this.command.CommandText = "SELECT Personalnummer FROM Mitarbeiter WHERE Name = 'Demny Paul' AND Passwort = 'Paul'";//"SELECT Personalnummer FROM Mitarbeiter WHERE Name = '" + this.name + "' AND Passwort = '" + new string(password) + "'";
            this.command.ExecuteNonQuery();
            this.reader = this.command.ExecuteReader();
            Console.WriteLine(reader.GetOrdinal("Personalnummer"));

        }
    }
}

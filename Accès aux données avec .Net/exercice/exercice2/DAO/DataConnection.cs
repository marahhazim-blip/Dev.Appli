using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exo02Commande.DAO
{
    internal class DataConnection
    {
        private static readonly string connectionString = "Server=localhost;Database=exo2_ado;User ID=root;Password=root";

        public static MySqlConnection GetConnection() {
            return new MySqlConnection(connectionString);

        }
    }
}

using Exo02Commande.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exo02Commande.DAO
{
    internal class ClientDAO
    {
        private string request = "";

        public Client Save(Client client)
        {
            string request = "INSERT INTO client (prenom, nom, adresse, code_postal, ville, telephone) VALUES (@prenom, @nom, @adresse, @code_postal, @ville, @telephone);";

            using MySqlConnection connection = DataConnection.GetConnection();
            using MySqlCommand command = new MySqlCommand(request, connection);

            command.Parameters.AddWithValue("@prenom", client.Prenom);
            command.Parameters.AddWithValue("@nom", client.Nom);
            command.Parameters.AddWithValue("@adresse", client.Adresse);
            command.Parameters.AddWithValue("@code_postal", client.CodePostal);
            command.Parameters.AddWithValue("@ville", client.Ville);
            command.Parameters.AddWithValue("@telephone", client.Telephone);

            connection.Open();
            command.ExecuteNonQuery();

            // Récupération de l’ID auto-généré par MySQL utile pour connaitre l'id attribue au client (auto increment en bdd)
            client.Id = (int)command.LastInsertedId;

            return client;
        }

        public Client Update(Client client)
        {
            request = "UPDATE client SET prenom=@prenom, nom=@nom, adresse=@adresse, code_postal=@code_postal, ville=@ville, telephone=@telephone WHERE id=@id;";

            using MySqlConnection connection = DataConnection.GetConnection();
            using MySqlCommand command = new MySqlCommand(request, connection);

            command.Parameters.AddWithValue("@prenom", client.Prenom);
            command.Parameters.AddWithValue("@nom", client.Nom);
            command.Parameters.AddWithValue("@adresse", client.Adresse);
            command.Parameters.AddWithValue("@code_postal", client.CodePostal);
            command.Parameters.AddWithValue("@ville", client.Ville);
            command.Parameters.AddWithValue("@telephone", client.Telephone);
            command.Parameters.AddWithValue("@id", client.Id);

            connection.Open();

            command.ExecuteNonQuery();

            return client;
        }

        public bool Delete(Client client)
        {
            // Suppression des commandes du client
            CommandeDAO commandeDAO = new CommandeDAO();
            commandeDAO.DeleteAllCommandsOfAClient(client);

            // Suppression du client
            request = "DELETE FROM client WHERE id=@id";
            using MySqlConnection connection = DataConnection.GetConnection();
            using MySqlCommand command = new MySqlCommand(request, connection);

            command.Parameters.AddWithValue("@id", client.Id);

            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected > 0;
        }

        public Client? GetOneById(int id)
        {
            Client? client = null;

            request = "SELECT id, prenom, nom, adresse, code_postal, ville, telephone FROM client WHERE id=@id;";

            using MySqlConnection connection = DataConnection.GetConnection();
            using MySqlCommand command = new MySqlCommand(request, connection);

            command.Parameters.AddWithValue("@id", id);

            connection.Open();

            using MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                client = new Client(reader.GetInt32("id"),
                    reader.GetString("prenom"),
                    reader.GetString("nom"),
                    reader.GetString("adresse"),
                    reader.GetString("code_postal"),
                    reader.GetString("ville"),
                    reader.GetString("telephone"));
            }

            if (client is not null)
            {
                CommandeDAO commandeDAO = new CommandeDAO();
                client.Commandes = commandeDAO.GetAllCommandsOfAClient(client);
            }

            return client;
        }

        public List<Client> GetAll()
        {
            List<Client> clients = new();

            request = "SELECT id, prenom, nom, adresse, code_postal, ville, telephone FROM client;";

            using MySqlConnection connection = DataConnection.GetConnection();
            using MySqlCommand command = new MySqlCommand(request, connection);

            connection.Open();

            using MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                clients.Add(
                    new Client(reader.GetInt32("id"),
                    reader.GetString("prenom"),
                    reader.GetString("nom"),
                    reader.GetString("adresse"),
                    reader.GetString("code_postal"),
                    reader.GetString("ville"),
                    reader.GetString("telephone")));
            }

            return clients;
        }
    }
}

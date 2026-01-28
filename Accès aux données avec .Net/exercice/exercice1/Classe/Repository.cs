using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1.Classe
{
    internal class Repository
    {

        private string connectionString = "Server=localhost;Database=exo1_ado ;User ID=root;Password=root";

        // CRUD
        // CREATE
        public bool Add(Livre livreAAjouter)
        {
            bool result = false;
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "INSERT INTO livres (titre,auteur,annee,isbn) VALUES (@titre,@auteur,@annee,@isbn)";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@titre", livreAAjouter.Titre);
                cmd.Parameters.AddWithValue("@auteur", livreAAjouter.Auteur);
                cmd.Parameters.AddWithValue("@annee", livreAAjouter.AnneePublication);
                cmd.Parameters.AddWithValue("@isbn", livreAAjouter.Isbn);

                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    result = true;
                }


            }
            catch (Exception e)
            {
               // Console.WriteLine("Erreur : " + e.Message);
                result = false;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        // READ
        public List<Livre> GetAllBooks()
        {
            List<Livre> livres = new List<Livre>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query = "SELECT * FROM livres";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Livre l = new Livre(
                            reader.GetInt32("id"),
                            reader.GetString("titre"),
                            reader.GetString("auteur"),
                            reader.GetInt32("annee"),
                            reader.GetString("isbn")
                            );
                        livres.Add(l);
                       // Console.WriteLine(l);

                    }
                }
                //else
                //{
                //   // Console.WriteLine("Aucun livre dans la base de donnée");

                //}
                reader.Close();

            }
            catch (Exception ex)
            {
              //  Console.WriteLine("Erreur : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return livres;


        }

        public Livre GetBookById(int id)
        {
            Livre livre = null;
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query = "SELECT * FROM livres WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Livre l = new Livre(
                             reader.GetInt32("id"),
                            reader.GetString("titre"),
                            reader.GetString("auteur"),
                            reader.GetInt32("annee"),
                            reader.GetString("isbn")
                            );
                    livre = l;
                  
                }
               

                reader.Close();
            }
            catch (Exception ex)
            {
              //  Console.WriteLine("Erreur : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return livre;

        }

        // UPDATE
        public void UpdateBook(int id,string newTitre,string newAuteur,string newIsbn,int newAnnee)
        {

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string queryCheck = "SELECT COUNT(*) FROM livres WHERE id = @id";
                MySqlCommand cmdCheck = new MySqlCommand(queryCheck, connection);
                cmdCheck.Parameters.AddWithValue("@id", id);
                int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (count == 0)
                {
                   // Console.WriteLine("Aucun livre trouvée avec cet Id");
                    return;
                }


                string query = "UPDATE livres SET titre = @t , auteur = @a , annee = @an , isbn = @i WHERE id = @id";


                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@t", newTitre);
                cmd.Parameters.AddWithValue("@a", newAuteur);
                cmd.Parameters.AddWithValue("@an", newAnnee);
                cmd.Parameters.AddWithValue("@i", newIsbn);

                int rowsAffected = cmd.ExecuteNonQuery();
               

            }
            catch (Exception ex)
            {
               // Console.WriteLine("Erreur : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        // DELETE 
        public void DeleteBook(int id) {

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query = "DELETE FROM livres WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
               // Console.WriteLine("Erreur :" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}

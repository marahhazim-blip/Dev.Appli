

//using Exercice1.Classe;
//using MySql.Data.MySqlClient;



//string connectionString = "Server=localhost;Database=exo1_ado ;User ID=root;Password=root";



//void AjouterLivre()
//{
//    Console.WriteLine("Ajout d'un Nouveaux Livre !!!!");
//    Console.WriteLine("Titre : ");
//    string titre = Console.ReadLine();
//    Console.WriteLine("Auteur : ");
//    string auteur = Console.ReadLine();
//    Console.WriteLine("Anne de publication : ");
//    int annee = int.Parse(Console.ReadLine());
//    Console.WriteLine("ISBN : ");
//    string isbn = Console.ReadLine();


//    Livre livre = new Livre(titre,auteur,annee,isbn);
//    MySqlConnection connection = new MySqlConnection(connectionString);

//    try
//    {
//        connection.Open();
//        string query = "INSERT INTO livres (titre,auteur,annee,isbn) VALUES (@titre,@auteur,@annee,@isbn)";

//        MySqlCommand cmd = new MySqlCommand(query, connection);

//        cmd.Parameters.AddWithValue("@titre", livre.Titre);
//        cmd.Parameters.AddWithValue("@auteur", livre.Auteur);
//        cmd.Parameters.AddWithValue("@annee", livre.AnneePublication);
//        cmd.Parameters.AddWithValue("@isbn", livre.Isbn);

//        int rowAffected = cmd.ExecuteNonQuery();
//        if (rowAffected > 0)
//        {
//            Console.WriteLine("livre ajouté avec succes");
//        }


//    }
//    catch (Exception e)
//    { 
//        Console.WriteLine("Erreur : " + e.Message);
//    }
//    finally
//    {
//        connection.Close();
//    }

//}


//void AfficherToutesLesLivres()
//{
//    Console.WriteLine("--- Liste des livres ---");
//    MySqlConnection connection = new MySqlConnection(connectionString);
//    try
//    {
//        connection.Open();

//        string query = "SELECT * FROM livres";

//        MySqlCommand cmd = new MySqlCommand(query, connection);
//        MySqlDataReader reader = cmd.ExecuteReader();

//        if (reader.HasRows)
//        {

//            while (reader.Read())
//            {
//                Livre l = new Livre(
//                    reader.GetInt32("id"),
//                    reader.GetString("titre"),
//                    reader.GetString("auteur"),
//                    reader.GetInt32("annee"),
//                    reader.GetString("isbn")
//                    );

//                Console.WriteLine(l);

//            }
//        }
//        else
//        {
//            Console.WriteLine("Aucun livre dans la base de donnée");
//        }
//        reader.Close();

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Erreur : " + ex.Message);
//    }
//    finally
//    {
//        connection.Close();
//    }
//}


//void RechercherLivreParId()
//{
//    Console.WriteLine("--- Recherche Par Id ---");
//    Console.WriteLine("Id du livre Recherché :");
//    var id = int.Parse(Console.ReadLine());

//    MySqlConnection connection = new MySqlConnection(connectionString);
//    try
//    {
//        connection.Open();

//        string query = "SELECT * FROM livres WHERE id = @id";
//        MySqlCommand cmd = new MySqlCommand(query, connection);
//        cmd.Parameters.AddWithValue("@id", id);

//        MySqlDataReader reader = cmd.ExecuteReader();

//        if (reader.Read())
//        {
//            Livre l = new Livre(
//                     reader.GetInt32("id"),
//                    reader.GetString("titre"),
//                    reader.GetString("auteur"),
//                    reader.GetInt32("annee"),
//                    reader.GetString("isbn")
//                    );

//            Console.WriteLine("Livre trouvé : " + l);
//        }
//        else
//        {
//            Console.WriteLine("Aucune Livre trouvée avec cet ID ");
//        }

//        reader.Close();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Erreur : " + ex.Message);
//    }
//    finally
//    {
//        connection.Close();
//    }
//}


//void UpdateLivre()
//{
//    Console.WriteLine("--- Modifier un Livre ---");
//    Console.WriteLine("Id du livre a modifier :");
//    var id = int.Parse(Console.ReadLine());

//    MySqlConnection connection = new MySqlConnection(connectionString);
//    try
//    {
//        connection.Open();

//        string queryCheck = "SELECT COUNT(*) FROM livres WHERE id = @id";
//        MySqlCommand cmdCheck = new MySqlCommand(queryCheck, connection);
//        cmdCheck.Parameters.AddWithValue("@id", id);
//        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

//        if (count == 0)
//        {
//            Console.WriteLine("Aucun livre trouvée avec cet Id");
//            return;
//        }

//        Console.WriteLine("Nouveau Titre :");
//        var titre = Console.ReadLine();
//        Console.WriteLine("Nouveau Auteur :");
//        var auteur = Console.ReadLine();
//        Console.WriteLine("nouvel Annee de publication :");
//        var annee = int.Parse(Console.ReadLine());
//        Console.WriteLine("Nouvel ISBN :");
//        var isbn = Console.ReadLine();


//        string query = "UPDATE livres SET titre = @t , auteur = @a , annee = @an , isbn = @i WHERE id = @id";


//        MySqlCommand cmd = new MySqlCommand(query, connection);
//        cmd.Parameters.AddWithValue("@id", id);
//        cmd.Parameters.AddWithValue("@t", titre);
//        cmd.Parameters.AddWithValue("@a", auteur);
//        cmd.Parameters.AddWithValue("@an", annee);
//        cmd.Parameters.AddWithValue("@i", isbn);

//        int rowsAffected = cmd.ExecuteNonQuery();
//        if (rowsAffected > 0)
//        {
//            Console.WriteLine("livre modifié avec succès");
//        }

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Erreur : " + ex.Message);
//    }
//    finally
//    {
//        connection.Close();
//    }
//}


//void DeleteLivre()
//{
//    Console.WriteLine("--- Supprimer un livre ---");
//    Console.WriteLine("Id du livre a supprimer :");
//    int id = int.Parse(Console.ReadLine());

//    MySqlConnection connection = new MySqlConnection(connectionString);
//    try
//    {
//        connection.Open();

//        string query = "DELETE FROM livres WHERE id = @id";
//        MySqlCommand cmd = new MySqlCommand(query, connection);
//        cmd.Parameters.AddWithValue("@id", id);

//        int rowsAffected = cmd.ExecuteNonQuery();

//        if (rowsAffected > 0)
//        {
//            Console.WriteLine("livre supprimé avec succès");
//        }
//        else
//        {
//            Console.WriteLine("Aucune livre trouvée a cet ID");
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Erreur :" + ex.Message);
//    }
//    finally
//    {
//        connection.Close();
//    }
//}

////AjouterLivre();
////AfficherToutesLesLivres();
////RechercherLivreParId();
////UpdateLivre();
//DeleteLivre();


using Exercice1.Classe;

new IHMConsoleLivre().Start();
 


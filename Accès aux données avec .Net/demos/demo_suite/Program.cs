
using DemoADO.Classes;
using MySql.Data.MySqlClient;

Console.WriteLine("Demo Suite ADO.NET");


string connectionString = "Server=localhost;Database=demo_ado;User ID=root;Password=root";

void AjouterAuteur()
{
    Console.WriteLine("--- Ajouter un auteur ---");
    Console.WriteLine("Nom :");
    var nom = Console.ReadLine();
    Console.WriteLine("Email :");
    var email = Console.ReadLine();

    Auteur auteur = new Auteur(nom, email);

    MySqlConnection connection = new MySqlConnection(connectionString);
    try
    {
        connection.Open();

        string query = "INSERT INTO Auteur (nom,email) VALUES (@nom,@email)";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@nom", auteur.Nom);
        cmd.Parameters.AddWithValue("@email", auteur.Email);

        int rows = cmd.ExecuteNonQuery();
        if (rows > 0)
        {
            Console.WriteLine("Auteur ajouté avec succès !");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erreur : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}

void AjouterLivre()
{
    Console.WriteLine("--- Ajouter un livre ---");
    Console.WriteLine("Id de l'auteur :");
    int auteurId = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);
    try
    {
        connection.Open();

        string queryCheck = "SELECT COUNT(*) FROM Auteur WHERE id = @id";
        MySqlCommand cmdCheck = new MySqlCommand(queryCheck, connection);
        cmdCheck.Parameters.AddWithValue("@id", auteurId);
        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

        if (count == 0)
        {
            Console.WriteLine("Aucun auteur trouvé avec cet Id.");
            return;
        }
        
        Console.WriteLine("Titre :");
        var titre = Console.ReadLine();
        Console.WriteLine("Année de publication :");
        int annee = int.Parse(Console.ReadLine());
        Console.WriteLine("ISBN :");
        var isbn = Console.ReadLine();

        Livre livre = new Livre(titre, annee, isbn, auteurId);

        string query = "INSERT INTO Livre (titre,annee_publication,isbn,auteur_id) VALUES (@titre,@annee,@isbn,@auteur_id)";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@titre", livre.Titre);
        cmd.Parameters.AddWithValue("@annee", livre.AnneePublication);
        cmd.Parameters.AddWithValue("@isbn", livre.Isbn);
        cmd.Parameters.AddWithValue("@auteur_id", livre.AuteurId);

        int rows = cmd.ExecuteNonQuery();
        if (rows > 0)
        {
            Console.WriteLine("Livre ajouté avec succès !");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erreur : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}


void AfficherTousLesAuteurs()
{
    Console.WriteLine("--- Liste des auteurs ---");
    MySqlConnection connection = new MySqlConnection(connectionString);
    try
    {
        connection.Open();

        string query = "SELECT * FROM Auteur";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Auteur a = new Auteur(
                    reader.GetInt32("id"),
                    reader.GetString("nom"),
                    reader.GetString("email")
                );

                Console.WriteLine(a);
            }
        }
        else
        {
            Console.WriteLine("Aucun auteur en base.");
        }

        reader.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erreur : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}


void AfficherTousLesLivres()
{
    Console.WriteLine("--- Liste des livres ---");
    MySqlConnection connection = new MySqlConnection(connectionString);
    try
    {
        connection.Open();

        string query = "SELECT * FROM Livre";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Livre l = new Livre(
                    reader.GetInt32("id"),
                    reader.GetString("titre"),
                    reader.GetInt32("annee_publication"),
                    reader.GetString("isbn"),
                    reader.GetInt32("auteur_id")
                );

                Console.WriteLine(l);
            }
        }
        else
        {
            Console.WriteLine("Aucun livre en base.");
        }

        reader.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erreur : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}


void AfficherAuteurAvecSesLivres()
{
    Console.WriteLine("--- Consulter un auteur et ses livres ---");
    Console.WriteLine("Id de l'auteur :");
    int auteurId = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);
    try
    {
        connection.Open();

        string query = @"
SELECT
  a.id AS auteur_id, a.nom AS auteur_nom, a.email AS auteur_email,
  l.id AS livre_id, l.titre, l.annee_publication, l.isbn, l.auteur_id
FROM Auteur a
LEFT JOIN Livre l ON l.auteur_id = a.id
WHERE a.id = @id;
";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@id", auteurId);

        MySqlDataReader reader = cmd.ExecuteReader();

        Auteur auteur = null;

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                if (auteur == null)
                {
                    auteur = new Auteur(
                        reader.GetInt32("auteur_id"),
                        reader.GetString("auteur_nom"),
                        reader.GetString("auteur_email")
                    );
                }

                if (!reader.IsDBNull(reader.GetOrdinal("livre_id")))
                {
                    Livre livre = new Livre(
                        reader.GetInt32("livre_id"),
                        reader.GetString("titre"),
                        reader.GetInt32("annee_publication"),
                        reader.GetString("isbn"),
                        reader.GetInt32("auteur_id")
                    );
                    auteur.Livres.Add(livre);
                }
            }
        }

        reader.Close();

        if (auteur == null)
        {
            Console.WriteLine("Aucun auteur trouvé avec cet Id.");
            return;
        }

        Console.WriteLine(auteur);
        foreach (var livre in auteur.Livres)
        {
            Console.WriteLine("  - " + livre);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erreur : " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}

CREATE DATABASE IF NOT EXISTS exercice1; 

USE exercice1; 

CREATE TABLE IF NOT EXISTS livres (
	id_livre INT AUTO_INCREMENT PRIMARY KEY,
    titre VARCHAR(255),
    auteur VARCHAR(255),
    annee_publication INT,
    genre VARCHAR(100),
    exemplaires_disponibles INT
);
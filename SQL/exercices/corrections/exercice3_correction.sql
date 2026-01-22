CREATE DATABASE IF NOT EXISTS exercice3; 

USE exercice3; 

CREATE TABLE IF NOT EXISTS clients (
	id_client INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE commandes (
	id_commande INT AUTO_INCREMENT PRIMARY KEY,
    date_commande DATE DEFAULT (CURRENT_DATE),
    montant DOUBLE NOT NULL CHECK (montant > 0),
    id_client INT NOT NULL,
    CONSTRAINT fk_id_client FOREIGN KEY (id_client) REFERENCES clients(id_client)
); 
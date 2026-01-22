CREATE DATABASE IF NOT EXISTS exercice2; 

USE exercice2; 

CREATE TABLE IF NOT EXISTS utilisateurs (
	id_utilisateur INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    age INT,
    pays VARCHAR(255) DEFAULT 'FRANCE',
    CONSTRAINT check_age CHECK (age >= 18)
);

ALTER TABLE utilisateurs
RENAME TO users;

ALTER TABLE users
ADD COLUMN prenom VARCHAR(200);

ALTER TABLE users
DROP CONSTRAINT check_age;

ALTER TABLE users
MODIFY nom VARCHAR(200);

-- Permet de voir les différentes contraintes présentes dans la BDD
-- SELECT * FROM INFORMATION_SCHEMA.CHECK_CONSTRAINT; 
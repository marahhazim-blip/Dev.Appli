-- DDL : DATA DEFINITION LANGAGE
-- Pour faire un commentaire, on utilise deux "-" suivi d'un espace 

-- Création d'une base de donnée
-- La création d'une base de donnée en MySQL implique de créer 
-- une seconde connexion pour y accéder.
-- Pour s'assurer de l'existence (ou non) d'un élément, nous pouvons ajouter IF (NOT) EXISTS
CREATE DATABASE IF NOT EXISTS demo1; 

-- Suppression d'une base de donnée.
DROP DATABASE IF EXISTS demo1;

-- Pour travailler dans la base donnée 'demo1', il est nécessaire de le spécifié à MySQL
USE demo1; 

-- ----------- CREATE TABLE -------------------

-- Pour créer une table, on utilise l'instruction CREATE TABLE
-- On peut vérifier que la table existe avant de la créer.
CREATE TABLE IF NOT EXISTS Services (
	service_id INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(255)
);

-- Suppression d'une table si elle existe.
DROP TABLE IF EXISTS Services; 

-- Pour modifier une table, nous utilisont le mot-clé ALTER TABLE
-- Pour la mofication, nous pouvons ajouter des colonnes.
ALTER TABLE Services
ADD COLUMN date_creation DATE; 

-- Pour modifier le type d'une colonne.
ALTER TABLE Services
MODIFY date_creation DATETIME; 

-- Nous pouvons également en supprimer. 
ALTER TABLE Services
DROP COLUMN date_creation;

-- Et nous pouvons aussi renommé nos différents tables.
ALTER TABLE Services
RENAME TO services_plus; 

-- Créer une table avec des contraintes
CREATE TABLE IF NOT EXISTS salarie (
	-- Primary Key permet d'ajouter une contrainte de type clé primaire (UNIQUE + NOT NULL)
	salarie_id INT AUTO_INCREMENT PRIMARY KEY,
    -- Not Null est une contrainte empêchant l'absence de valeur
    prenom VARCHAR(255) NOT NULL,
    nom VARCHAR(255) NOT NULL,
    -- la contrainte CHECK permet d'ajouter un mécanisme de vérification
    age INT NOT NULL CHECK (age >= 18),
    -- la contriante DEFAULT permet de définir une valeur par défaut en cas d'absence de valeur renseigné.
    salaire DECIMAL DEFAULT 1500.0,
    service_id INT NOT NULL, 
    -- Il est possible d'ajouter des contraintes nommée avec le mot-clé CONSTRAINT
    -- Pour les clé étrangères nous devons renseigner le champs de la table salarie qui sera notre clé étrangère
    -- Puis dans REFERENCES, nous devons spécifer la table et la clé primaire qui serait en relation avec notre table actuel.
    CONSTRAINT fk_service_id FOREIGN KEY (service_id) REFERENCES Services(service_id)
); 
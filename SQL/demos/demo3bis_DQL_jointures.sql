CREATE DATABASE demo2;

USE demo2;

CREATE TABLE IF NOT EXISTS Services (
	service_id INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(255),
    date_creation DATE DEFAULT (CURRENT_DATE)
);

CREATE TABLE IF NOT EXISTS salarie (
	salarie_id INT AUTO_INCREMENT PRIMARY KEY,
    prenom VARCHAR(255) NOT NULL,
    nom VARCHAR(255) NOT NULL,
    age INT NOT NULL CHECK (age >= 18),
    salaire DECIMAL DEFAULT 1500.0,
    service_id INT -- Pas de contrainte pour l'exemple mais mauvaise pratique
); 

INSERT INTO services (libelle)
VALUES
	('Informatique'),
    ('Ressources Humaines'),
    ('Comptabilite'); -- Un service qui ne possede pas de salarie
    
INSERT INTO salarie (nom, prenom, age, salaire, service_id)
VALUES
	("Jean", "Dupont", 30, 1400, 1),
    ("Michelle", "Dufour", 29, 2800, 2),
    ("Geralt", "De rives", 24, 1500, 1),
    ("Jasquier", "Dandelion", 41, 2100, 2),
    ("Eren", "Jager", 20, 2000, 1),
    ("Mikasa", "Ackerman", 25, 2200, 2),
    ("Carl", "Johnson", 35, 3000, 1),
    ("Joe", "Dalton", 27, 600, 2),
    ("Avrel", "Dalton", 22, 300, 4); -- Un salarie qui possede un service inexistant
    
    
-- Pour joindre 2 tables ensemble, nous devons préciser la Table à joindre après le type de jointure
-- Ici, jointure est de type INNER JOIN (uniquement les données qui peuvent être jointes seront visibles).
SELECT salarie.prenom , salarie.nom, services.libelle 
FROM salarie
INNER JOIN services ON services.service_id = salarie.service_id; -- le ON donne l'élément qui sera la clé de notre jointure.

-- Il est possible d'ajouter des alias pour le nom de nos tables afin de simplifier notre requête.
SELECT sa.prenom , sa.nom, se.libelle
FROM salarie AS sa
INNER JOIN services AS se ON se.service_id = sa.service_id;

-- Le LEFT JOIN va récupérer toutes les valeurs croiser plus les valeurs de la table du FROM (même si, on ne peut pas les joindres)
SELECT sa.prenom , sa.nom, se.libelle
FROM salarie AS sa
LEFT JOIN services AS se ON se.service_id = sa.service_id;

-- Le RIGHT JOIN va récupérer toutes les valeurs croiser plus les valeurs de la table du JOIN (même si, on ne peut pas les joindres)
SELECT sa.prenom , sa.nom, se.libelle
FROM salarie AS sa
RIGHT JOIN services AS se ON se.service_id = sa.service_id;

-- Pour le FULL JOIN, nous devons unir un LEFT JOIN + un RIGHT JOIN
SELECT sa.prenom , sa.nom, se.libelle
FROM salarie AS sa
LEFT JOIN services AS se ON se.service_id = sa.service_id
UNION
SELECT sa.prenom , sa.nom, se.libelle
FROM salarie AS sa
RIGHT JOIN services AS se ON se.service_id = sa.service_id;













    
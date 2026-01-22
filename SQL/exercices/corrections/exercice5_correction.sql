CREATE DATABASE exercice5;

USE exercice5;

CREATE TABLE services (
	service_id INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(200) NOT NULL,
    date_creation DATE DEFAULT (CURRENT_DATE)
); 

CREATE TABLE employes (
	employe_id INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(200) NOT NULL,
    prenom VARCHAR(200),
    service_id INT NOT NULL,
    CONSTRAINT fk_service_id FOREIGN KEY (service_id) REFERENCES services (service_id)
);


INSERT INTO services (libelle)
VALUES ('Informatique'); 

INSERT INTO services (libelle, date_creation)
VALUES ('Ressources Humaines', '2024-01-01'); 

INSERT INTO services (libelle)
VALUES ('Marketing'); 

SET SQL_SAFE_UPDATES = 0;

UPDATE services 
SET libelle = 'IT'
WHERE libelle = "Informatique";

UPDATE services 
SET date_creation = CURRENT_DATE
WHERE libelle = "Ressources Humaines";

DELETE FROM services
WHERE libelle = "Marketing";

DELETE FROM services
WHERE date_creation < "2024-01-01";

INSERT INTO employes (nom, prenom, service_id)
VALUES ("Martin", "Paul", 1), ("Dupont", "Claire", 1), ("Bernard", "Sophie", 2); 

UPDATE employes
SET nom = "Martinez"
WHERE nom = "Martin";

DELETE FROM employes
WHERE prenom = "Claire";







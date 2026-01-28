CREATE DATABASE exo2_ado;

USE exo2_ado;

CREATE TABLE client (
	id INT PRIMARY KEY AUTO_INCREMENT,
	prenom VARCHAR(50),
	nom VARCHAR(50),
	adresse VARCHAR(255),
	code_postal VARCHAR(5),
	ville VARCHAR(100),
	telephone VARCHAR(10)
);

CREATE TABLE commande (
	id INT PRIMARY KEY AUTO_INCREMENT,
	total DECIMAL,
	date_commande DATETIME,
	client_id INT,
	CONSTRAINT FK_client_commande_client_id FOREIGN KEY (client_id) REFERENCES client(id)
);
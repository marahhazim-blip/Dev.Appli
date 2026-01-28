
CREATE TABLE auteur (
	id INT AUTO_INCREMENT,
    nom VARCHAR(150),
    email VARCHAR(150),
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS Livre (
  id INT NOT NULL AUTO_INCREMENT,
  titre VARCHAR(150) NOT NULL,
  annee_publication INT NOT NULL,
  isbn VARCHAR(30) NOT NULL,
  auteur_id INT NOT NULL,
  PRIMARY KEY (id),
  CONSTRAINT fk_livre_auteur FOREIGN KEY (auteur_id) REFERENCES Auteur(id)
);
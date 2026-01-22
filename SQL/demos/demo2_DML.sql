-- ------ INSERTION ----------

-- Pour insérer une valeur dabs une table, nous utilisons la commande INSERT INTO
-- Si aucune parathèse n'est mise nous devons renseigner la totalité des champs
INSERT INTO services (libelle) 
-- Le mot-clé VALUES nous permet d'insérer les valeurs précisé dans le INSERT INTO
VALUES ('Informatique'); 

ALTER TABLE services
ADD COLUMN date_creation DATE;

-- Nous pouvons insérer plusieurs valeurs d'un coup en séparant les enregistrements par une ','
INSERT INTO services (libelle, date_creation)
VALUES
	('RH', '2025-12-09'),
    ('Comptabilite', '2025-12-09') ;

-- Format timestamp (date-heure) : AAAA-MM-DD HH:mm:SS

-- -------- MISE A JOUR ------------------

-- Cette commande permet de retirer le safe mode pour les mise à jour et permettre les modifications sur l'ensemble de la table.
SET SQL_SAFE_UPDATES = 0;

-- Pour mettre à jour une ou plusieurs dans une table, nous utilisons le mot-clé UPDATE suivie de SET.
UPDATE services
SET date_creation = '2025-12-09'
WHERE service_id = 1;

-- Pour mettre à jour plusieurs attribut, il suffit de les préciser dans le SET en les séparant par une virgule.
UPDATE services
SET libelle = 'Ressources Humaines', date_creation = '2025-12-09'
WHERE service_id = 2;

-- ------ SUPPRESSION --------------

-- Pour supprimer un élément par son id
DELETE FROM services
WHERE service_id = 3;

-- Attention en l'absence de WHERE, le DELETE va supprimer l'ensemble des enregistrements de la table.
DELETE FROM services;

-- Le TRUNCATE effectue également une suppression intégrale de la table de façon plus performante MAIS c'est irréversible.
TRUNCATE services; 








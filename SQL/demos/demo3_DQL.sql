USE demo1;

INSERT INTO salarie (nom, prenom, age, salaire, service_id)
VALUES
	("Jean", "Dupont", 30, 1400, 1),
    ("Michelle", "Dufour", 29, 2800, 2),
    ("Geralt", "De rives", 24, 1500, 1),
    ("Jasquier", "Dandelion", 41, 2100, 2),
    ("Eren", "Jager", 20, 2000, 1),
    ("Mikasa", "Ackerman", 25, 2200, 2),
    ("Carl", "Johnson", 35, 3000, 1),
    ("Joe", "Dalton", 27, 600, 2);
    
-- Sélectionner toutes les colonnes d'une tables
SELECT * FROM salarie; 

-- Sélectionner des colonnes spécifiques
SELECT nom, prenom
FROM salarie; 

-- Alias pour les colonnes
SELECT libelle AS nom_service, date_creation AS creation
FROM services; 

-- La clause Where permet de filtrer les résultats de la requete
SELECT *
FROM salarie
WHERE salarie_id = 1; 

SELECT *
FROM salarie
WHERE salaire > 2000 AND age > 20; 

SELECT *
FROM salarie
WHERE salaire > 3000 OR ( age > 30 AND NOT service_id = 1); 

-- Nous pouvons fournir une plage de valeur dans notre filtre WHERE
-- Pour rechercher des termes spécifiques, nous utilisons le mot-clé insert
SELECT *
FROM salarie
WHERE nom IN ('Joe', 'Jasquier', 'Jean');

SELECT *
FROM salarie
WHERE age NOT IN (20, 25, 35);

-- Pour rechercher un élement qui fait partie d'une plage de valeur, nous utilisont BETWEEN..AND
SELECT *
FROM salarie
WHERE salaire BETWEEN 1500 AND 2500; -- Les valeurs données sont incluses

SELECT *
FROM salarie
WHERE age NOT BETWEEN 20 AND 30; 

-- Le distinct permet de récupérer les élements sans afficher de doublon
SELECT DISTINCT age 
FROM salarie;

-- Le LIKE permet d'effectuer une recherche sur une partie d'une chaine de caractere
SELECT * 
FROM salarie
WHERE prenom LIKE 'J%'; 

SELECT * 
FROM salarie
WHERE prenom LIKE 'J____';

SELECT * 
FROM salarie
WHERE prenom LIKE '%g%';

-- ORDER BY 
-- Permet d'ordonner le jeu de résultat par rapport à une ou plusieurs colonnes
-- de manière croisssante (ASC) ou décroissante (DESC)
-- Par défaut: ASC, pas besoin de le préciser
SELECT *
FROM salarie
ORDER BY prenom; 

SELECT *
FROM salarie
ORDER BY nom DESC; 

SELECT *
FROM salarie
ORDER BY service_id, prenom; 

-- LIMIT 
-- Permet de limiter le nombre de résultats obtenue
SELECT prenom, salaire
FROM salarie
ORDER BY salaire DESC
LIMIT 3; 

-- OFFSET permet de décaler le jeu de résultats que l'on récupère
SELECT prenom, salaire
FROM salarie
ORDER BY salaire DESC
LIMIT 3
OFFSET 3; 


-- Fonction d'aggrégation et GROUP BY
-- Ici, nous récupérons le salaire maximum avec MAX() 
SELECT MAX(salaire) AS salaire_maximum
FROM salarie; 

-- ROUND permet d'arrondir une valeur et AVG de calculer la valeur moyenne de la colonne spécifié
SELECT ROUND(AVG(salaire)) AS salaire_moyen
FROM salarie;

-- Le GROUP BY va permettre de regrouper les salaire moyen par service_id.
SELECT AVG(salaire) AS salaire_moyen, service_id
FROM salarie
GROUP BY service_id; 

-- Le HAVING permet d'ajouter une condition à chaque groupe réalisé par le GROUP BY
SELECT AVG(age) AS age_moyen, service_id
FROM salarie
GROUP BY service_id
HAVING AVG(age) > 30; 

-- Les sous-requêtes
-- Elles peuvent êtes placé dans le WHERE afin de récupérer un résultat au préalable
SELECT prenom, nom, salaire
FROM salarie
WHERE salaire = (SELECT MAX(salaire) FROM salarie);

-- Nous pouvons également effectuer notre sous-requête dans une autre table.
SELECT prenom, nom, service_id
FROM salarie
WHERE service_id = (SELECT service_id FROM services WHERE libelle = 'Informatique'); 

-- La sous-requête peut être placé dans le FROM, dans ce cas le résultat de la sous-requête agira comme une table temporaire.
SELECT prenom, nom, salaire, age
FROM (SELECT * FROM salarie WHERE age > 30) AS employe_plus_30_ans
WHERE salaire > 2000;










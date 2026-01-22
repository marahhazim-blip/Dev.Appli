-- a
SELECT c.prenom, c.nom, a.produit, a.montant
FROM clients AS c
INNER JOIN achats AS a ON c.id = a.client_id;

-- b
SELECT c.prenom, c.nom, a.produit, a.montant
FROM achats AS a
LEFT JOIN clients AS c ON c.id = a.client_id;

-- c
SELECT c.prenom, c.nom, a.produit, a.montant
FROM achats AS a
RIGHT JOIN clients AS c ON c.id = a.client_id;

-- d

SELECT c.prenom, c.nom, a.produit, a.montant
FROM achats AS a
LEFT JOIN clients AS c ON c.id = a.client_id
UNION
SELECT c.prenom, c.nom, a.produit, a.montant
FROM achats AS a
RIGHT JOIN clients AS c ON c.id = a.client_id;




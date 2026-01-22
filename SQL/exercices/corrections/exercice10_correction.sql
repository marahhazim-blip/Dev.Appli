-- 1
SELECT * 
FROM users
WHERE job IN ('Engineer'); 

-- 2
SELECT first_name, last_name, location
FROM users
WHERE location IN ('London', 'Paris', 'Berlin'); 

-- 3 
SELECT *
FROM users
WHERE age BETWEEN 25 AND 35; 

-- 4 
SELECT *
FROM users
WHERE job IN ('Developer') AND salary > 2500;

-- 5
SELECT *
FROM users
WHERE job NOT IN ('Lawyer', 'Designer'); 

-- 6 
-- Sélectionner les utilisateurs dont l'age ne soit pas compris entre 30 et 40 ans et 
-- dont le lieu de naissance est soit 'Tokyo' soit 'Los Angeles'
SELECT * 
FROM users
WHERE age NOT BETWEEN 30 AND 40 
AND location IN ('Tokyo', 'Los Angeles');


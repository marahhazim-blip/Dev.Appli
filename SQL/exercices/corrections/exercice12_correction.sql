-- Exercice 12
USE exercices; 

-- 1
SELECT *
FROM users
ORDER BY age DESC
LIMIT 5;

-- 2 
SELECT *
FROM users
ORDER BY first_name ASC
LIMIT 5 
OFFSET 5; 

-- 3 
SELECT *
FROM users
ORDER BY salary DESC
LIMIT 3; 



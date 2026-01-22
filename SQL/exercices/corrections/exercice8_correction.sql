-- Exercice 8

SELECT *
FROM users
WHERE age < 30 OR age >= 35; 

SELECT *
FROM users
WHERE (job = 'Teacher' AND salary >= 2600); 
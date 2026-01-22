-- Correction Exercice 11 

-- 1
SELECT *
FROM users
WHERE first_name LIKE 'D%';
 
-- 2 
SELECT *
FROM users
WHERE last_name LIKE '%son';

-- 3 
SELECT *
FROM users
WHERE first_name LIKE '_____';

-- 4 
SELECT *
FROM users
WHERE job LIKE '%Doctor%';


DROP TABLE IF EXISTS users;

CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    job VARCHAR(100),
    birth_date DATE,
    location VARCHAR(100)
);

INSERT INTO users (first_name, last_name, job, birth_date, location)
VALUES
    ('John', 'Doe', 'Developer', '1995-05-12', 'New York'),
    ('Alice', 'Smith', 'Designer', '1988-09-28', 'London'),
    ('Michael', 'Johnson', 'Engineer', '1977-02-05', 'Los Angeles'),
    ('Emily', 'Brown', 'Teacher', '1992-04-18', 'Paris'),
    ('David', 'Lee', 'Doctor', '1985-11-30', 'Tokyo'),
    ('Sarah', 'Wilson', 'Lawyer', '1990-06-08', 'Sydney'),
    ('Daniel', 'Anderson', 'Developer', '1983-12-21', 'Toronto'),
    ('Jessica', 'Taylor', 'Engineer', '1991-10-15', 'Berlin'),
    ('Christopher', 'Moore', 'Designer', '1997-01-04', 'Rome'),
    ('Olivia', 'Jackson', 'Teacher', '1994-08-22', 'Moscow'),
    ('James', 'Doe', 'Engineer', '1987-03-12', 'New York'),
    ('Sophia', 'Smith', 'Developer', '1993-07-28', 'London'),
    ('Emma', 'Johnson', 'Designer', '1980-09-05', 'Los Angeles'),
    ('Daniel', 'Brown', 'Doctor', '1992-02-18', 'Paris'),
    ('David', 'Lee', 'Lawyer', '1985-11-30', 'Tokyo'),
    ('Lucas', 'Clark', 'Data Analyst', '1982-10-14', 'Madrid'),
    ('Amelia', 'Miller', 'Architect', '1989-07-25', 'Toronto'),
    ('Ethan', 'Martinez', 'Photographer', '1991-11-11', 'Paris'),
    ('Mia', 'Garcia', 'Nurse', '1993-05-04', 'Mexico City'),
    ('William', 'Martinez', 'Scientist', '1985-03-22', 'New York'),
    ('Noah', 'White', 'Artist', '1990-12-03', 'Chicago'),
    ('Isabella', 'Davis', 'Chef', '1988-06-17', 'London'),
    ('Liam', 'Rodriguez', 'Developer', '1981-09-20', 'San Francisco'),
    ('Mason', 'Lopez', 'Engineer', '1986-04-05', 'Los Angeles'),
    ('Sophia', 'Hill', 'Teacher', '1992-01-16', 'Toronto'),
    ('Benjamin', 'Green', 'Developer', '1997-08-19', 'Berlin'),
    ('Lucas', 'Baker', 'Pilot', '1984-10-30', 'London'),
    ('Harper', 'Gonzalez', 'Scientist', '1989-12-10', 'Paris'),
    ('Henry', 'Phillips', 'Writer', '1983-11-25', 'New York'),
    ('Ella', 'Evans', 'Teacher', '1994-03-08', 'Berlin'),
    ('Elijah', 'Torres', 'Photographer', '1992-09-22', 'New York'),
    ('Ava', 'Young', 'Lawyer', '1986-07-09', 'Sydney'),
    ('Logan', 'Scott', 'Doctor', '1987-02-18', 'Melbourne'),
    ('Mason', 'Bennett', 'Designer', '1990-05-30', 'London'),
    ('Grace', 'Stewart', 'Engineer', '1992-07-19', 'Toronto'),
    ('Oliver', 'Hughes', 'Developer', '1989-12-25', 'New York'),
    ('Chloe', 'Reed', 'Doctor', '1985-11-30', 'Paris'),
    ('Jack', 'Cooper', 'Lawyer', '1990-04-14', 'Tokyo'),
    ('Lily', 'King', 'Teacher', '1983-09-27', 'Sydney'),
    ('Zoe', 'Wright', 'Designer', '1994-05-06', 'Los Angeles');

SET SQL_SAFE_UPDATES = 0;

ALTER TABLE users
ADD COLUMN age INT,
ADD COLUMN salary INT NOT NULL DEFAULT 0;

UPDATE users
SET age = TIMESTAMPDIFF(YEAR, birth_date, CURDATE());

UPDATE users
SET salary = FLOOR(2000 + RAND() * (3500 - 2000));

-- Select *
-- from users 

-- Select first_name, last_name, job
-- from users 

-- Select *
-- from users 
-- WHERE Job NOT IN ('developer');

-- Select *
-- from users 
-- WHERE first_name IN ('John');

-- Select *
-- from users 
-- WHERE salary >= 3000;

-- Select *
-- from users 
-- WHERE age < 30 
-- OR age >=35;

-- Select *
-- from users 
-- WHERE job = 'Teacher'
-- and (salary>=2600)

-- Select *
-- from users 
-- WHERE location = 'New York'
-- and (salary>=3000 and salary <=3500) 
-- and (job <> 'Doctor' and job <> 'Lawyer');

-- SELECT *
-- FROM users 
-- WHERE first_name IN ('John','Mason','Zoe');
 
SELECT *
FROM users 
WHERE Job IN ('Engineer');

SELECT first_name, last_name, location
FROM Users
-- WHERE location = 'Paris' OR location = 'London' OR location='Berlin';
WHERE location IN ('Paris','London','Berlin');

SELECT first_name, last_name, age
FROM Users
WHERE age BETWEEN 25 AND 35;

SELECT *
FROM Users
WHERE Job IN ('developer') AND salary >= 2500;

Select *
from users 
WHERE job NOT IN  ('Lawyer', 'Designer');

SELECT *
FROM Users
WHERE age NOT BETWEEN 30 AND 40 
AND location IN ('Tokyo','Los Angeles');

SELECT *
FROM Users
WHERE first_name LIKE 'D%';

SELECT *
FROM Users
WHERE last_name LIKE '%son';

SELECT *
FROM Users
WHERE first_name LIKE '_____';

SELECT *
FROM Users
WHERE job LIKE '%Doctor%';


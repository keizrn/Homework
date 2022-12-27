
-- create
CREATE TABLE classmates (
  studId INTEGER PRIMARY KEY,
  name TEXT NOT NULL,
  age INTEGER NOT NULL,
  address TEXT NOT NULL
);

-- insert
INSERT INTO classmates VALUES (0001, 'Мария Загородникова', 41, 'Екатеринбург');
INSERT INTO classmates VALUES (0002, 'Андрей Пиев', 42, 'Москва');
INSERT INTO classmates VALUES (0003, 'Дмитрий Джурабаев', 34, 'Ковров');
INSERT INTO classmates VALUES (0004, 'Майбродский Максим', 40, 'Москва');
INSERT INTO classmates VALUES (0005, 'Вадим Шкода', 32, 'Москва');
INSERT INTO classmates VALUES (0006, 'Василий Юрицын', 36, 'Москва');
INSERT INTO classmates VALUES (0007, 'Дарья Дмитричева', 26, 'Санкт-Петербург');
INSERT INTO classmates VALUES (0008, 'Даша Новикова', 18, 'Москва');
INSERT INTO classmates VALUES (0009, 'Анна Афанасьева', 34, 'Ростов-на-Дону');
INSERT INTO classmates VALUES (0010, 'Роман Гончареня', 41, 'Санкт-Петербург');
INSERT INTO classmates VALUES (0011, 'Антон Смолин', 28, 'Москва');

-- fetch
SELECT name FROM classmates WHERE address = 'Москва' AND (age >= 18 AND age < 30)
ORDER BY name asc;
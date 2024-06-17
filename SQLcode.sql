-- Подготовка исходных данных

-- Создание таблицы Categories
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100)
);

-- Вставка исходных данных в таблицу Categories
INSERT INTO Categories (CategoryID, CategoryName)
VALUES
    (1, N'Кухня'),
    (2, N'Гостиная'),
    (3, N'Техника');

-- Создание таблицы Products
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Price DECIMAL(10, 2)
);

-- Вставка исходных данных в таблицу Products
INSERT INTO Products (ProductID, ProductName, Price)
VALUES
    (1, N'Ноутбук', 59999.99),
    (2, N'Стол', 3999.99),
    (3, N'Стул', 1990.50),
    (4, N'Кровать', 8800.00),
    (5, N'Картофель', 39.95),
    (6, N'Телевизор', 35000.99);

-- Создание таблицы для связи многие-ко-многим ProductCategories
CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Вставка данных в таблицу ProductCategories для связей продуктов и категорий
INSERT INTO ProductCategories (ProductID, CategoryID)
VALUES
    (1, 3), -- Ноутбук относится к категории Техника
    (2, 1), -- Стол относится к категории Кухня
    (2, 2), -- Стол относится к категории Гостиная  
    (3, 1), -- Стул относится к категории Кухня
    (3, 2), -- Стул относится к категории Гостиная  
    (4, 2), -- Кровать относится к категории Гостиная
    (6, 1), -- Телевизор относится к категории Кухня
    (6, 2), -- Телевизор относится к категории Гостиная  
    (6, 3); -- Телевизор относится к категории Техника
-- =======================================================================================


--  Выбор всех пар в формате «Имя продукта – Имя категории».
SELECT
    p.ProductName,
	c.CategoryName
FROM
    Products p
LEFT JOIN
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN
    Categories c ON pc.CategoryID = c.CategoryID;

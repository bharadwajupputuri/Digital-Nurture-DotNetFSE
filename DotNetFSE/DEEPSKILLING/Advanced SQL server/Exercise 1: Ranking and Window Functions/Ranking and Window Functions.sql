CREATE DATABASE RetailStoreDB;
USE RetailStoreDB;
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);
INSERT INTO Products VALUES
(1,'Laptop A','Electronics',80000),
(2,'Laptop B','Electronics',75000),
(3,'Laptop C','Electronics',75000),
(4,'Mouse','Electronics',1500),
(5,'Keyboard','Electronics',2500),
(6,'Shirt A','Clothing',1200),
(7,'Shirt B','Clothing',1500),
(8,'Jeans A','Clothing',2200),
(9,'Jeans B','Clothing',2200),
(10,'Jacket','Clothing',3500),
(11,'Novel A','Books',450),
(12,'Novel B','Books',600),
(13,'Novel C','Books',600),
(14,'Dictionary','Books',900),
(15,'Magazine','Books',200);
SELECT * FROM Products;
SELECT *
FROM (
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNum
    FROM Products
) AS RankedProducts
WHERE RowNum <= 3;
SELECT *
FROM (
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RankNo
    FROM Products
) AS RankedProducts
WHERE RankNo <= 3;
SELECT *
FROM (
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS DenseRankNo
    FROM Products
) AS RankedProducts
WHERE DenseRankNo <= 3;
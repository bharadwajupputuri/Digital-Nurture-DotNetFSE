# README

# Advanced SQL Exercises for Online Retail Store

## Exercise 1: Ranking and Window Functions

---

## Objective

The objective of this exercise is to learn and implement SQL Window Functions in MySQL. We use `ROW_NUMBER()`, `RANK()`, `DENSE_RANK()`, `OVER()`, and `PARTITION BY` to rank products within each category based on their prices and retrieve the top three most expensive products.

---

## Software Requirements

- MySQL Server 8.0 or above
- MySQL Workbench
- Windows Operating System

> **Note:** Window Functions are supported only in MySQL 8.0 and above.

---

## Database Name

```
RetailStoreDB
```

---

## Table Name

```
Products
```

---

## Table Structure

| Column Name | Data Type | Description |
|-------------|-----------|-------------|
| ProductID | INT | Primary Key |
| ProductName | VARCHAR(100) | Name of the Product |
| Category | VARCHAR(50) | Product Category |
| Price | DECIMAL(10,2) | Product Price |

---

# Procedure

### Step 1: Create the Database

```sql
CREATE DATABASE RetailStoreDB;
```

---

### Step 2: Select the Database

```sql
USE RetailStoreDB;
```

---

### Step 3: Create the Products Table

```sql
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);
```

---

### Step 4: Insert Sample Data

```sql
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
```

---

### Step 5: Display the Table

```sql
SELECT * FROM Products;
```

---

# Exercise 1 – Using ROW_NUMBER()

### Query

```sql
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
```

### Purpose

- Assigns a unique row number to each product within its category.
- Returns the top three products from every category.

---

# Exercise 2 – Using RANK()

### Query

```sql
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
```

### Purpose

- Assigns the same rank to products with equal prices.
- Skips the next rank after duplicate values.

Example:

```
Laptop A  -> Rank 1
Laptop B  -> Rank 2
Laptop C  -> Rank 2
Keyboard  -> Rank 4
```

---

# Exercise 3 – Using DENSE_RANK()

### Query

```sql
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
```

### Purpose

- Assigns the same rank to products with equal prices.
- Does not skip any ranks.

Example:

```
Laptop A  -> Rank 1
Laptop B  -> Rank 2
Laptop C  -> Rank 2
Keyboard  -> Rank 3
```

---

# Window Functions Used

## OVER()

Defines the set of rows on which the ranking function is performed.

---

## PARTITION BY

Divides the data into groups based on the `Category` column.

Each category is ranked independently.

Example:

- Electronics
- Clothing
- Books

---

## ORDER BY Price DESC

Sorts products from highest price to lowest price before ranking.

---

# Comparison of Ranking Functions

| Function | Duplicate Values | Rank Skipped |
|----------|------------------|--------------|
| ROW_NUMBER() | No | No |
| RANK() | Yes | Yes |
| DENSE_RANK() | Yes | No |

---

# Results

- Successfully created the `RetailStoreDB` database.
- Created the `Products` table.
- Inserted 15 sample records.
- Retrieved all product records.
- Applied `ROW_NUMBER()` to generate unique rankings.
- Applied `RANK()` to observe skipped rankings for duplicate prices.
- Applied `DENSE_RANK()` to observe continuous rankings without gaps.
- Displayed the top three most expensive products in each category.

---

# Learning Outcomes

After completing this exercise, we learned how to:

- Create a database in MySQL.
- Create tables with appropriate data types.
- Insert records into a table.
- Retrieve records using the `SELECT` statement.
- Use SQL Window Functions.
- Apply `OVER()` with ranking functions.
- Group records using `PARTITION BY`.
- Sort records using `ORDER BY`.
- Compare the behavior of `ROW_NUMBER()`, `RANK()`, and `DENSE_RANK()`.
- Retrieve top-N records from each category.

---

# Conclusion

This experiment successfully demonstrated the use of SQL Window Functions in MySQL. We created the **RetailStoreDB** database, created the **Products** table, inserted sample product data, and applied `ROW_NUMBER()`, `RANK()`, and `DENSE_RANK()` using `OVER()`, `PARTITION BY`, and `ORDER BY`. The experiment helped us understand how different ranking functions handle duplicate values and how they can be used to retrieve the top-ranked records within each category.

# README

# Advanced SQL Exercises – Indexing in MySQL

## Objective

The objective of this experiment is to understand the concept of indexing in MySQL and analyze how indexes improve query performance. This exercise demonstrates the creation and use of **Non-Clustered Index**, **Composite Index**, and explains the behavior of **Clustered Indexes** in MySQL.

---

## Software Requirements

- MySQL Server 8.0 or above
- MySQL Workbench
- Windows Operating System

---

## Database Name

```text
RetailStoreIndexDB
```

---

## Tables Used

- Customers
- Products
- Orders
- OrderDetails

---

## Database Schema

### Customers Table

| Column Name | Data Type | Description |
|-------------|-----------|-------------|
| CustomerID | INT | Primary Key |
| Name | VARCHAR(100) | Customer Name |
| Region | VARCHAR(50) | Customer Region |

### Products Table

| Column Name | Data Type | Description |
|-------------|-----------|-------------|
| ProductID | INT | Primary Key |
| ProductName | VARCHAR(100) | Product Name |
| Category | VARCHAR(50) | Product Category |
| Price | DECIMAL(10,2) | Product Price |

### Orders Table

| Column Name | Data Type | Description |
|-------------|-----------|-------------|
| OrderID | INT | Primary Key |
| CustomerID | INT | Foreign Key |
| OrderDate | DATE | Order Date |

### OrderDetails Table

| Column Name | Data Type | Description |
|-------------|-----------|-------------|
| OrderDetailID | INT | Primary Key |
| OrderID | INT | Foreign Key |
| ProductID | INT | Foreign Key |
| Quantity | INT | Quantity Ordered |

---

# Procedure

## Step 1: Create the Database

```sql
CREATE DATABASE RetailStoreIndexDB;
USE RetailStoreIndexDB;
```

---

## Step 2: Create the Tables

Created the following tables:

- Customers
- Products
- Orders
- OrderDetails

using appropriate Primary Keys and Foreign Keys.

---

## Step 3: Insert Sample Data

Inserted sample customer, product, order, and order detail records into all tables.

---

## Step 4: Verify Data

```sql
SELECT * FROM Customers;

SELECT * FROM Products;

SELECT * FROM Orders;

SELECT * FROM OrderDetails;
```

---

# Exercise 1 – Creating a Non-Clustered Index

## Aim

Create a non-clustered index on the **ProductName** column of the **Products** table and compare query execution before and after index creation.

### Query Before Index

```sql
SELECT * FROM Products
WHERE ProductName='Laptop';
```

### Create Index

```sql
CREATE INDEX idx_ProductName
ON Products(ProductName);
```

### Query After Index

```sql
SELECT * FROM Products
WHERE ProductName='Laptop';
```

### Observation

- The index speeds up searching based on the **ProductName** column.
- MySQL can locate records more efficiently without scanning the entire table.

---

# Exercise 2 – Understanding Clustered Index

## Aim

Study the concept of clustered indexes in MySQL.

### Query Before Index

```sql
SELECT * FROM Orders
WHERE OrderDate='2023-01-15';
```

### Create Index

```sql
CREATE INDEX idx_OrderDate
ON Orders(OrderDate);
```

### Query After Index

```sql
SELECT * FROM Orders
WHERE OrderDate='2023-01-15';
```

### Observation

- In MySQL (InnoDB), the **Primary Key** is automatically used as the clustered index.
- Users cannot manually create a clustered index.
- A normal index on **OrderDate** improves the performance of searches using that column.

---

# Exercise 3 – Creating a Composite Index

## Aim

Create a composite index on **CustomerID** and **OrderDate** in the **Orders** table.

### Query Before Index

```sql
SELECT *
FROM Orders
WHERE CustomerID=1
AND OrderDate='2023-01-15';
```

### Create Composite Index

```sql
CREATE INDEX idx_Customer_OrderDate
ON Orders(CustomerID,OrderDate);
```

### Query After Index

```sql
SELECT *
FROM Orders
WHERE CustomerID=1
AND OrderDate='2023-01-15';
```

### Observation

- The composite index improves query performance when filtering by both **CustomerID** and **OrderDate** together.
- It is more efficient than using separate indexes for these columns in this type of query.

---

# Types of Indexes Used

## 1. Non-Clustered Index

- Stores the index separately from the table data.
- Improves search performance on specific columns.
- Example:

```sql
CREATE INDEX idx_ProductName
ON Products(ProductName);
```

---

## 2. Clustered Index

- Organizes the table data based on the Primary Key.
- In MySQL InnoDB, the Primary Key automatically becomes the clustered index.
- Users cannot explicitly create clustered indexes.

---

## 3. Composite Index

- Created using multiple columns.
- Improves performance when queries use all indexed columns together.

Example:

```sql
CREATE INDEX idx_Customer_OrderDate
ON Orders(CustomerID,OrderDate);
```

---

# Results

- Successfully created the **RetailStoreIndexDB** database.
- Created all required tables with primary and foreign key constraints.
- Inserted sample customer, product, order, and order detail records.
- Created a non-clustered index on the **ProductName** column.
- Created an index on the **OrderDate** column.
- Created a composite index on **CustomerID** and **OrderDate**.
- Executed queries before and after index creation.
- Observed improved query performance with indexes.

---

# Learning Outcomes

After completing this experiment, we were able to:

- Understand the purpose of indexing in databases.
- Create databases and tables in MySQL.
- Insert and retrieve records.
- Create and use non-clustered indexes.
- Understand how clustered indexes work in MySQL.
- Create composite indexes using multiple columns.
- Improve query performance using indexes.
- Analyze the advantages of different indexing techniques.

---

# Conclusion

This experiment successfully demonstrated the implementation of indexing techniques in MySQL. A retail store database was created with multiple related tables, and sample data was inserted. A non-clustered index on **ProductName**, an index on **OrderDate**, and a composite index on **CustomerID** and **OrderDate** were created to optimize query performance. The experiment also highlighted that MySQL's InnoDB storage engine automatically uses the Primary Key as the clustered index. Overall, this exercise provided practical knowledge of indexing techniques and their importance in improving database query performance.

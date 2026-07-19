-- ==========================================
-- Create Database
-- ==========================================

CREATE DATABASE EmployeeManagementDB;

USE EmployeeManagementDB;


-- ==========================================
-- Create Departments Table
-- ==========================================

CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


-- ==========================================
-- Create Employees Table
-- ==========================================

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);


-- ==========================================
-- Insert Department Data
-- ==========================================

INSERT INTO Departments VALUES
(1,'HR'),
(2,'Finance'),
(3,'IT');


-- ==========================================
-- Insert Employee Data
-- ==========================================

INSERT INTO Employees VALUES
(1,'John','Doe',1,5000.00,'2020-01-15'),
(2,'Jane','Smith',2,6000.00,'2019-03-22'),
(3,'Bob','Johnson',3,5500.00,'2021-07-01');


-- Check Data

SELECT * FROM Departments;

SELECT * FROM Employees;



-- ==========================================
-- Exercise 7:
-- Create Scalar Function
-- Calculate Annual Salary
-- ==========================================

DELIMITER //

CREATE FUNCTION fn_CalculateAnnualSalary(
    EmpID INT
)
RETURNS DECIMAL(10,2)
DETERMINISTIC

BEGIN

    DECLARE AnnualSalary DECIMAL(10,2);

    SELECT Salary * 12
    INTO AnnualSalary
    FROM Employees
    WHERE EmployeeID = EmpID;

    RETURN AnnualSalary;

END //

DELIMITER ;



-- ==========================================
-- Execute Scalar Function
-- EmployeeID = 1
-- ==========================================

SELECT 
    EmployeeID,
    FirstName,
    LastName,
    Salary,
    fn_CalculateAnnualSalary(EmployeeID) AS AnnualSalary
FROM Employees
WHERE EmployeeID = 1;
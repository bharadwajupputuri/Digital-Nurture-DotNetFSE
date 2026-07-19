-- =====================================
-- Create Database
-- =====================================

CREATE DATABASE EmployeeManagementDB;

USE EmployeeManagementDB;


-- =====================================
-- Create Departments Table
-- =====================================

CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


-- =====================================
-- Create Employees Table
-- =====================================

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) 
    REFERENCES Departments(DepartmentID)
);


-- =====================================
-- Insert Department Data
-- =====================================

INSERT INTO Departments 
(DepartmentID, DepartmentName)
VALUES
(1,'HR'),
(2,'Finance'),
(3,'IT'),
(4,'Marketing');


-- =====================================
-- Insert Employee Data
-- =====================================

INSERT INTO Employees
(EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
(1,'John','Doe',1,5000.00,'2020-01-15'),
(2,'Jane','Smith',2,6000.00,'2019-03-22'),
(3,'Michael','Johnson',3,7000.00,'2018-07-30'),
(4,'Emily','Davis',4,5500.00,'2021-11-05');


-- Check Tables

SELECT * FROM Departments;

SELECT * FROM Employees;



-- =====================================
-- Exercise 1:
-- Stored Procedure to Retrieve Employee
-- Details Based on Department ID
-- =====================================

DELIMITER //

CREATE PROCEDURE GetEmployeesByDepartment(
    IN Department_ID INT
)
BEGIN

    SELECT 
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    FROM Employees
    WHERE DepartmentID = Department_ID;

END //

DELIMITER ;


-- Execute Stored Procedure

CALL GetEmployeesByDepartment(3);



-- =====================================
-- Exercise 2:
-- Stored Procedure to Insert Employee
-- =====================================

DELIMITER //

CREATE PROCEDURE sp_InsertEmployee(
    IN First_Name VARCHAR(50),
    IN Last_Name VARCHAR(50),
    IN Dept_ID INT,
    IN Emp_Salary DECIMAL(10,2),
    IN Emp_JoinDate DATE
)

BEGIN

    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        First_Name,
        Last_Name,
        Dept_ID,
        Emp_Salary,
        Emp_JoinDate
    );

END //

DELIMITER ;


-- Execute Insert Procedure

CALL sp_InsertEmployee(
'Robert',
'Wilson',
2,
6500.00,
'2023-06-15'
);


-- Verify Inserted Employee

SELECT * FROM Employees;
-- Execute Stored Procedure to retrieve employee details by DepartmentID

CALL GetEmployeesByDepartment(3);
CALL GetEmployeesByDepartment(1);
CALL GetEmployeesByDepartment(2);
CALL GetEmployeesByDepartment(4);
-- Exercise 5: Stored Procedure to Return Total Number of Employees in a Department

DELIMITER //

CREATE PROCEDURE CountEmployeesByDepartment(
    IN DeptID INT
)
BEGIN
    SELECT 
        DepartmentID,
        COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = DeptID
    GROUP BY DepartmentID;
END //

DELIMITER ;


-- Execute Stored Procedure

CALL CountEmployeesByDepartment(3);
# Factory Method Pattern Example

## Project Title
**Implementing the Factory Method Design Pattern in Java**

---

## Objective

The objective of this project is to implement the **Factory Method Design Pattern** in Java. The Factory Method pattern provides an interface for creating objects while allowing subclasses to decide which specific object to instantiate. This promotes loose coupling between object creation and object usage.

In this project, a **Document Management System** is developed that creates different types of documents such as **Word**, **PDF**, and **Excel** using separate factory classes.

---

## Design Pattern Used

- **Pattern Name:** Factory Method Pattern
- **Category:** Creational Design Pattern

---

## Problem Statement

A document management system needs to support multiple document types such as Microsoft Word, PDF, and Excel. Instead of directly creating objects using the `new` keyword, the application should delegate object creation to factory classes.

The Factory Method Pattern solves this problem by:

- Encapsulating object creation.
- Reducing dependency between the client and concrete classes.
- Making the application easy to extend with new document types.

---

## Project Structure

```
FactoryMethodPatternExample/
│
├── Document.java
├── WordDocument.java
├── PdfDocument.java
├── ExcelDocument.java
├── DocumentFactory.java
├── WordDocumentFactory.java
├── PdfDocumentFactory.java
├── ExcelDocumentFactory.java
├── FactoryMethodTest.java
└── README.md
```

---

## Files Description

### 1. Document.java
An interface that defines the common operation for all document types.

Method:
- `open()`

---

### 2. WordDocument.java
Implements the `Document` interface and represents a Microsoft Word document.

---

### 3. PdfDocument.java
Implements the `Document` interface and represents a PDF document.

---

### 4. ExcelDocument.java
Implements the `Document` interface and represents an Excel spreadsheet.

---

### 5. DocumentFactory.java
An abstract factory class that declares the factory method:

```java
public abstract Document createDocument();
```

It also contains a method to create and open the document.

---

### 6. WordDocumentFactory.java
Creates objects of `WordDocument`.

---

### 7. PdfDocumentFactory.java
Creates objects of `PdfDocument`.

---

### 8. ExcelDocumentFactory.java
Creates objects of `ExcelDocument`.

---

### 9. FactoryMethodTest.java
Contains the `main()` method used to test the Factory Method implementation.

The program creates different factory objects and uses them to generate different document types.

---

## Implementation Steps

### Step 1: Create the Java Project

Created a Java project named:

```
FactoryMethodPatternExample
```

---

### Step 2: Create the Document Interface

Defined a common interface named `Document` containing the `open()` method.

---

### Step 3: Implement Concrete Document Classes

Created three document classes:

- WordDocument
- PdfDocument
- ExcelDocument

Each class provides its own implementation of the `open()` method.

---

### Step 4: Create the Abstract Factory

Created an abstract class named `DocumentFactory` containing:

- Abstract method `createDocument()`
- Method `openDocument()` to create and open a document

---

### Step 5: Create Concrete Factory Classes

Implemented factory classes:

- WordDocumentFactory
- PdfDocumentFactory
- ExcelDocumentFactory

Each factory overrides `createDocument()` to create the appropriate document object.

---

### Step 6: Test the Implementation

Created `FactoryMethodTest.java` to demonstrate:

- Creating Word documents
- Creating PDF documents
- Creating Excel documents

using the Factory Method Pattern.

---

## Working Flow

```
Application Starts
        │
        ▼
Create Factory Object
        │
        ▼
Call createDocument()
        │
        ▼
Factory Creates Required Document
        │
        ▼
Return Document Object
        │
        ▼
Call open()
        │
        ▼
Display Document Type
        │
        ▼
Program Ends
```

---

## Sample Output

```
Opening Microsoft Word Document...
Opening PDF Document...
Opening Excel Spreadsheet...
```

---

## Key Concepts Used

- Java Interfaces
- Abstract Classes
- Inheritance
- Polymorphism
- Method Overriding
- Object-Oriented Programming (OOP)
- Factory Method Design Pattern

---

## Advantages of Factory Method Pattern

- Promotes loose coupling.
- Separates object creation from business logic.
- Makes the application easy to extend.
- Improves maintainability.
- Supports the Open/Closed Principle.
- Reduces dependency on concrete classes.

---

## Applications of Factory Method Pattern

The Factory Method Pattern is widely used in:

- Document Management Systems
- GUI Frameworks
- Database Drivers
- Payment Gateway Integration
- Notification Services (Email, SMS, Push)
- Game Development
- Logging Frameworks
- Report Generation Systems

---

## Technologies Used

- Java
- JDK 25
- Visual Studio Code
- PowerShell Terminal

---

## How to Compile

Open the terminal inside the project folder and execute:

```bash
javac *.java
```

If wildcard compilation is not supported, use:

```bash
javac Document.java WordDocument.java PdfDocument.java ExcelDocument.java DocumentFactory.java WordDocumentFactory.java PdfDocumentFactory.java ExcelDocumentFactory.java FactoryMethodTest.java
```

---

## How to Execute

Run the application using:

```bash
java FactoryMethodTest
```

---

## Expected Result

The application successfully demonstrates the Factory Method Design Pattern by creating different document objects through their respective factory classes. The client interacts only with the factory classes, without directly instantiating the concrete document classes.

---

## Conclusion

This project successfully implements the **Factory Method Design Pattern** in Java. The design separates object creation from object usage by delegating the responsibility of creating document objects to dedicated factory classes. The implementation demonstrates how different document types—Word, PDF, and Excel—can be created dynamically while maintaining loose coupling, better code organization, and improved scalability.

---

## Author

**Name:** Avula Bhavana

**Project:** Factory Method Pattern Example

**Language:** Java

**Design Pattern:** Factory Method Pattern

**IDE:** Visual Studio Code

# Singleton Pattern Example

## Project Title
**Implementing the Singleton Design Pattern in Java**

## Objective
The objective of this project is to implement the **Singleton Design Pattern** in Java. The Singleton pattern ensures that a class has only one instance throughout the application's lifecycle and provides a global point of access to that instance.

In this project, a `Logger` class is implemented as a Singleton to ensure consistent logging using a single shared object.

---

## Design Pattern Used
- **Pattern Name:** Singleton Pattern
- **Category:** Creational Design Pattern

---

## Problem Statement

In many applications, certain classes such as loggers, configuration managers, database connections, and cache managers should have only one instance. Creating multiple instances of these classes can lead to inconsistent behavior and unnecessary resource usage.

The Singleton Design Pattern solves this problem by:
- Restricting object creation to a single instance.
- Providing a global access point to that instance.

---

## Project Structure

```
SingletonPatternExample/
│
├── Logger.java
├── SingletonTest.java
└── README.md
```

---

## Files Description

### 1. Logger.java
This class implements the Singleton Design Pattern.

Features:
- Private static instance of the class.
- Private constructor to prevent external object creation.
- Public static `getInstance()` method to return the single instance.
- `log()` method to print log messages.

### 2. SingletonTest.java
This class contains the `main()` method used to test the Singleton implementation.

Functions:
- Retrieves the Logger instance twice.
- Logs two different messages.
- Verifies that both references point to the same object.
- Prints the hash codes of both objects.

---

## Implementation Steps

### Step 1: Create a Java Project
Created a project named:

```
SingletonPatternExample
```

### Step 2: Create the Logger Class
- Declared a private static instance.
- Made the constructor private.
- Implemented the `getInstance()` method.

### Step 3: Implement Singleton Logic
When `getInstance()` is called:
- If no object exists, create one.
- Otherwise, return the existing object.

### Step 4: Test the Implementation
Created `SingletonTest.java` to:
- Access the Logger object.
- Compare object references.
- Display hash codes.

---

## Code Flow

```
Application Starts
        │
        ▼
Call Logger.getInstance()
        │
        ▼
Is instance null?
      /      \
    Yes       No
    │          │
Create      Return
Object     Existing Object
    │          │
    └──────┬───┘
           ▼
      Log Messages
           │
           ▼
 Verify Same Instance
           │
           ▼
        Program Ends
```

---

## Sample Output

```
Logger Instance Created
LOG: Application Started
LOG: User Logged In
Both logger objects are the same.
Logger1 HashCode: 980546781
Logger2 HashCode: 980546781
```

> **Note:** The hash code values may differ on different systems, but both values will always be identical because only one object is created.

---

## Key Concepts Used

- Java Classes
- Objects
- Constructors
- Static Variables
- Static Methods
- Object References
- Encapsulation
- Singleton Design Pattern

---

## Advantages of Singleton Pattern

- Ensures only one instance of a class exists.
- Saves memory by avoiding multiple object creation.
- Provides a global access point.
- Maintains consistent application state.
- Easy to implement and use.

---

## Applications of Singleton Pattern

The Singleton pattern is commonly used in:

- Logging Systems
- Database Connection Managers
- Configuration Managers
- Cache Managers
- Thread Pools
- Printer Spoolers
- Application Settings
- Runtime Environment Objects

---

## Technologies Used

- Java
- JDK 25
- Visual Studio Code
- PowerShell Terminal

---

## How to Compile

Open the terminal inside the project folder and run:

```bash
javac Logger.java SingletonTest.java
```

---

## How to Execute

Run the compiled program using:

```bash
java SingletonTest
```

---

## Expected Result

The application successfully demonstrates the Singleton Design Pattern by creating only one instance of the `Logger` class. Multiple calls to `getInstance()` return the same object, which is verified using object comparison and identical hash codes.

---

## Conclusion

This project successfully implements the Singleton Design Pattern in Java. The `Logger` class is designed to allow only one object throughout the application's lifecycle, ensuring efficient resource usage and consistent logging behavior. The test program confirms that multiple requests for the Logger instance always return the same object, validating the Singleton implementation.

---

## Author

**Name:** Avula Bhavana

**Project:** Singleton Pattern Example

**Language:** Java

**Design Pattern:** Singleton Pattern

**IDE:** Visual Studio Code

# E-Commerce Platform Search Function

## Project Title
**Implementation and Analysis of Linear Search and Binary Search Algorithms in Java**

---

# Objective

The objective of this project is to implement and analyze two searching algorithms—**Linear Search** and **Binary Search**—for an E-commerce platform. The project demonstrates how different search algorithms perform when searching for products and compares their time complexities to determine the most suitable algorithm for large-scale applications.

---

# Problem Statement

An E-commerce platform contains thousands of products. Users search for products using their product ID or other attributes. The search operation should be efficient and provide quick results.

To achieve this, two search algorithms are implemented:

- Linear Search
- Binary Search

The performance of both algorithms is analyzed using **Big O Notation**.

---

# Learning Outcomes

After completing this project, we are able to:

- Understand Big O Notation.
- Analyze algorithm efficiency.
- Implement Linear Search.
- Implement Binary Search.
- Compare the performance of searching algorithms.
- Identify the most suitable search algorithm for an E-commerce platform.

---

# Project Structure

```
ECommerceSearchExample/
│
├── Product.java
├── SearchTest.java
└── README.md
```

---

# Files Description

## 1. Product.java

This class represents a product in the E-commerce system.

### Attributes

- productId
- productName
- category

### Methods

- Constructor
- display()

This class stores product information used during searching.

---

## 2. SearchTest.java

This class contains:

- Linear Search implementation
- Binary Search implementation
- Main method for testing
- Product array creation
- Sorting products for Binary Search
- Displaying search results

---

# Concepts Used

- Java Classes
- Objects
- Arrays
- Loops
- Conditional Statements
- Methods
- Sorting using Arrays.sort()
- Comparator
- Big O Notation
- Linear Search
- Binary Search

---

# Big O Notation

## Definition

Big O Notation is a mathematical representation used to describe the time complexity of an algorithm as the input size increases.

It helps us determine:

- Algorithm efficiency
- Execution speed
- Scalability
- Performance comparison

---

# Common Time Complexities

| Complexity | Description |
|------------|-------------|
| O(1) | Constant Time |
| O(log n) | Logarithmic Time |
| O(n) | Linear Time |
| O(n log n) | Linearithmic Time |
| O(n²) | Quadratic Time |

---

# Search Algorithms

## 1. Linear Search

### Definition

Linear Search checks every element one by one until the required element is found.

### Working

1. Start from the first element.
2. Compare each product ID.
3. If matched, return the product.
4. Otherwise continue until the end.

### Advantages

- Easy to implement.
- Works on unsorted data.
- Suitable for small datasets.

### Disadvantages

- Slow for large datasets.

---

## 2. Binary Search

### Definition

Binary Search repeatedly divides the sorted array into two halves until the required element is found.

### Working

1. Sort the array.
2. Find the middle element.
3. Compare the middle element with the target.
4. Search the left half or right half.
5. Repeat until found.

### Advantages

- Very fast.
- Efficient for large datasets.
- Requires fewer comparisons.

### Disadvantages

- Works only on sorted data.

---

# Implementation Steps

## Step 1

Created a Java project named

```
ECommerceSearchExample
```

---

## Step 2

Created a Product class containing

- productId
- productName
- category

---

## Step 3

Stored multiple Product objects inside an array.

---

## Step 4

Implemented Linear Search algorithm.

---

## Step 5

Sorted the array using

```java
Arrays.sort(products, Comparator.comparingInt(p -> p.productId));
```

---

## Step 6

Implemented Binary Search algorithm.

---

## Step 7

Executed both algorithms and displayed the search result.

---

# Program Flow

```
Application Starts
        │
        ▼
Create Product Objects
        │
        ▼
Store Products in Array
        │
        ▼
Perform Linear Search
        │
        ▼
Display Result
        │
        ▼
Sort Product Array
        │
        ▼
Perform Binary Search
        │
        ▼
Display Result
        │
        ▼
Program Ends
```

---

# Sample Input

Searching Product ID

```
103
```

---

# Sample Output

```
===== Linear Search =====

Product ID : 103
Product Name : Shoes
Category : Fashion

===== Binary Search =====

Product ID : 103
Product Name : Shoes
Category : Fashion
```

---

# Time Complexity Analysis

| Algorithm | Best Case | Average Case | Worst Case |
|------------|-----------|--------------|-------------|
| Linear Search | O(1) | O(n) | O(n) |
| Binary Search | O(1) | O(log n) | O(log n) |

---

# Comparison Between Linear Search and Binary Search

| Feature | Linear Search | Binary Search |
|---------|---------------|---------------|
| Data Requirement | Unsorted | Sorted |
| Best Case | O(1) | O(1) |
| Average Case | O(n) | O(log n) |
| Worst Case | O(n) | O(log n) |
| Implementation | Easy | Moderate |
| Performance | Slow | Fast |
| Suitable for Large Data | No | Yes |

---

# Which Algorithm is Better?

For an **E-commerce platform**, **Binary Search** is the better choice because:

- Product databases contain thousands or millions of records.
- Products can be stored in sorted order.
- Binary Search significantly reduces the number of comparisons.
- It provides faster search results.
- Improves overall application performance and user experience.

Linear Search is useful only when:

- The dataset is very small.
- The data is unsorted.
- Simplicity is preferred over performance.

---

# Technologies Used

- Java
- JDK 25
- Visual Studio Code
- PowerShell Terminal

---

# How to Compile

Open the terminal inside the project folder and execute:

```bash
javac Product.java SearchTest.java
```

---

# How to Run

Execute the program using:

```bash
java SearchTest
```

---

# Expected Result

The program successfully searches for a product using both Linear Search and Binary Search algorithms. The search results are displayed correctly, and the time complexity analysis demonstrates that Binary Search is more efficient for large datasets due to its logarithmic time complexity.

---

# Applications

Searching algorithms are widely used in:

- E-commerce websites
- Online shopping applications
- Inventory Management Systems
- Library Management Systems
- Banking Applications
- Hospital Management Systems
- Student Record Management Systems
- Search Engines

---

# Conclusion

This project successfully demonstrates the implementation of **Linear Search** and **Binary Search** in Java using an E-commerce product dataset. The project highlights the importance of algorithm analysis through **Big O Notation** and compares the efficiency of both search techniques. While Linear Search is simple and works with unsorted data, Binary Search offers significantly better performance for sorted datasets. Therefore, Binary Search is the preferred algorithm for large-scale E-commerce platforms where fast and efficient product searching is essential.

---

# Author

**Name:** Avula Bhavana

**Project:** E-Commerce Platform Search Function

**Language:** Java

**IDE:** Visual Studio Code

**JDK Version:** 25

**Course:** Engineering Concepts

# Financial Forecasting Using Recursion

## Project Title
**Financial Forecasting Tool using Recursive Algorithm in Java**

---

# Objective

The objective of this project is to develop a **Financial Forecasting Tool** that predicts the future value of an investment or asset based on the current value, annual growth rate, and number of years using a **recursive algorithm**.

The project also demonstrates the concept of **recursion**, analyzes its time complexity, and discusses possible optimizations to improve performance.

---

# Problem Statement

Financial forecasting is widely used by businesses, banks, investors, and financial analysts to estimate future values based on historical growth rates.

Given:

- Current Value
- Annual Growth Rate
- Number of Years

The application predicts the future value using recursion by applying the annual growth rate repeatedly until the desired number of years is reached.

---

# Learning Outcomes

After completing this project, we are able to:

- Understand recursion and recursive algorithms.
- Implement a recursive solution in Java.
- Predict future financial values using compound growth.
- Analyze the time complexity of recursive algorithms.
- Identify methods to optimize recursive solutions.

---

# Project Structure

```
FinancialForecastingExample/
│
├── FinancialForecast.java
└── README.md
```

---

# File Description

## FinancialForecast.java

This file contains:

- Recursive method to calculate future value
- User input using Scanner
- Future value calculation
- Display of predicted financial value

---

# Concepts Used

- Java Programming
- Classes and Objects
- Methods
- Recursion
- Base Case
- Recursive Case
- Scanner Class
- Mathematical Computation
- Time Complexity Analysis
- Space Complexity Analysis

---

# Understanding Recursion

## What is Recursion?

Recursion is a programming technique where a method calls itself repeatedly to solve a problem by breaking it into smaller subproblems.

Every recursive algorithm consists of:

- Base Case
- Recursive Case

The recursion continues until the base condition becomes true.

---

# Base Case

The base case stops the recursive calls.

```java
if (years == 0)
    return currentValue;
```

When no years are left, the current value becomes the final future value.

---

# Recursive Case

```java
return calculateFutureValue(
        currentValue * (1 + growthRate),
        growthRate,
        years - 1
);
```

Each recursive call:

- Applies the annual growth rate.
- Decreases the number of years by one.
- Continues until the base case is reached.

---

# Financial Formula Used

The future value follows the compound growth formula:

```
Future Value = Current Value × (1 + Growth Rate)^Years
```

Instead of calculating the power directly, recursion applies the growth rate one year at a time.

---

# Working Principle

Example:

Current Value = 10000

Growth Rate = 10%

Years = 5

The recursive execution follows:

```
Year 5

10000

↓

11000

↓

12100

↓

13310

↓

14641

↓

16105.10

↓

Return Final Value
```

---

# Implementation Steps

## Step 1

Created a Java project named

```
FinancialForecastingExample
```

---

## Step 2

Created the class

```
FinancialForecast
```

---

## Step 3

Accepted user inputs:

- Current Value
- Annual Growth Rate
- Number of Years

using the Scanner class.

---

## Step 4

Implemented a recursive method:

```
calculateFutureValue()
```

to predict the future financial value.

---

## Step 5

Used:

- Base Case
- Recursive Case

to repeatedly calculate the compound growth.

---

## Step 6

Displayed the final predicted financial value.

---

# Program Flow

```
Application Starts
        │
        ▼
Read Current Value
        │
        ▼
Read Growth Rate
        │
        ▼
Read Number of Years
        │
        ▼
Call Recursive Function
        │
        ▼
Apply Growth Rate
        │
        ▼
Decrease Year Count
        │
        ▼
Base Case Reached?
      /       \
    No         Yes
    │           │
Recursive      Return
Call         Future Value
    │
    ▼
Display Result
        │
        ▼
Program Ends
```

---

# Sample Input

```
Current Value : 10000

Growth Rate : 10

Years : 5
```

---

# Sample Output

```
Future Value after 5 years = 16105.10
```

---

# Time Complexity Analysis

Each recursive call processes one year.

If the number of years is **n**,

```
Time Complexity = O(n)
```

because the recursive function executes **n** times.

---

# Space Complexity Analysis

Each recursive call occupies memory in the call stack.

Therefore,

```
Space Complexity = O(n)
```

---

# Optimization of Recursive Solution

Although recursion provides a simple and elegant solution, excessive recursive calls may consume more memory.

The recursive solution can be optimized using:

### 1. Iterative Approach

Use a loop instead of recursion.

Advantages:

- Eliminates recursive calls.
- Reduces memory usage.
- Space Complexity becomes **O(1)**.

---

### 2. Mathematical Formula

Use Java's built-in `Math.pow()` method.

Example:

```java
futureValue = currentValue * Math.pow(1 + growthRate, years);
```

Advantages:

- Faster execution.
- No recursion.
- Minimal memory usage.

---

# Advantages of Recursion

- Easy to understand.
- Reduces code complexity.
- Natural solution for recursive problems.
- Useful for divide-and-conquer algorithms.
- Improves code readability.

---

# Disadvantages of Recursion

- Uses additional stack memory.
- Slower than iteration for simple problems.
- Risk of StackOverflowError for very deep recursion.
- Higher function call overhead.

---

# Applications of Financial Forecasting

Financial forecasting is used in:

- Banking Systems
- Investment Planning
- Stock Market Analysis
- Business Revenue Prediction
- Sales Forecasting
- Budget Planning
- Retirement Planning
- Insurance Companies
- Economic Analysis

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
javac FinancialForecast.java
```

---

# How to Run

Run the application using:

```bash
java FinancialForecast
```

---

# Expected Result

The program successfully predicts the future financial value by recursively applying the annual growth rate for the specified number of years. It demonstrates the practical use of recursion in solving forecasting problems while highlighting the importance of analyzing algorithm efficiency and optimization techniques.

---

# Conclusion

This project successfully implements a **Financial Forecasting Tool** using a recursive algorithm in Java. The recursive method accurately calculates the future value by applying compound growth year by year until the base condition is reached. The project also emphasizes the role of **Big O analysis**, showing that the recursive solution has **O(n)** time complexity and **O(n)** space complexity. While recursion offers a clean and intuitive implementation, iterative methods or mathematical formulas such as `Math.pow()` can further optimize performance for large inputs. Overall, the project demonstrates both the practical application of recursion and the importance of algorithm optimization in software development.

---

# Author

**Name:** Avula Bhavana

**Project:** Financial Forecasting Using Recursion

**Language:** Java

**IDE:** Visual Studio Code

**JDK Version:** 25

**Course:** Engineering Concepts

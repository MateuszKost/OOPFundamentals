# Lesson #X - Abstract Classes vs Interfaces vs Virtual Methods

## Overview

In this lesson, you will learn about three fundamental mechanisms in object-oriented programming in C#:

- **Abstract Classes**
- **Interfaces**
- **Virtual Methods**

You will understand what they are, how they differ, when to use each, and their advantages and limitations.

---

## What are they?

### Abstract Classes
- Classes that cannot be instantiated directly.
- Can contain both implemented methods and abstract methods (without implementation).
- Serve as a blueprint for derived classes, enforcing implementation of certain methods.

### Interfaces
- Define a contract — a set of methods and properties that a class must implement.
- Do not contain state or implementation (although newer versions of C# allow default implementations).
- Allow multiple inheritance of contracts.

### Virtual Methods
- Methods with an implementation in the base class that can be overridden in derived classes.
- Enable polymorphism and customizing method behavior.

---

## Differences at a glance

| Feature                  | Abstract Class                  | Interface                           | Virtual Method                    |
|--------------------------|---------------------------------|-------------------------------------|----------------------------------|
| Can be instantiated      | No                              | No                                  | Yes (belongs to a class instance)|
| Implementation           | Partial (can have code)         | No (except default implementations) | Yes (has default implementation) |
| Multiple inheritance     | No                              | Yes                                 | N/A                              |
| Forces implementation    | Yes, for abstract methods       | Yes, for all interface members      | No (overriding optional)         |
| Contains fields/state    | Yes                             | No                                  | N/A                              |

---

## When to use?

- **Abstract Classes**: When you want a base class with partial implementation and enforce overriding important methods.
- **Interfaces**: When you need a contract for classes to implement, especially if they might implement multiple interfaces.
- **Virtual Methods**: When you want to provide a default implementation but allow derived classes to override it.

---

## This lesson includes:

- Code examples demonstrating the use of each construct
- Explanation of differences and best practices

---

## Next steps

After mastering this lesson, you can move on to studying inheritance, polymorphism, and design patterns based on these mechanisms.

---

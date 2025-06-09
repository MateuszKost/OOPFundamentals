# 🛠️ Lesson: Constructors and Overloading in C#

## ✅ What is a Constructor?

A **constructor** is a special method that gets called when an object is created.  
It’s typically used to **initialize fields or properties** of a class.

---

## 🔄 What is Constructor Overloading?

**Constructor overloading** means providing **multiple constructors with different parameter sets**.  
This allows more flexibility in how objects are created.

---

## 🧪 In This Project

We use a `Person` class with several constructors:

### Constructors Demonstrated

| Constructor | Description |
|-------------|-------------|
| `Person()` | Default values for all properties |
| `Person(string name)` | Name only, others set to default |
| `Person(string name, int age)` | Name and age only |
| `Person(string name, int age, string country)` | All properties (uses constructor chaining) |

---

## 🔍 Why Use Constructor Overloading?

- Provide **sensible defaults** when not all information is available
- Allow for **cleaner and more flexible object creation**
- Reduce repetition using **constructor chaining** (`: this(...)`)

---

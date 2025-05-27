# Lesson 01 – Introduction to Object-Oriented Programming (OOP)

This project explains the fundamentals of **Object-Oriented Programming (OOP)** in C#. It introduces the main ideas behind OOP, including its motivation, core principles, and practical benefits.

---

## 🧠 What is OOP?

**OOP (Object-Oriented Programming)** is a programming paradigm based on the concept of "objects". An object represents a real-world entity that combines:

- **Data** (fields/properties),
- **Behavior** (methods).

Instead of organizing logic as flat procedures (like in procedural programming), OOP models the world using structured types (classes, structs, etc.).

---

## 🎯 Why use OOP?

- Improves code **modularity** and **reusability**.
- Makes systems **easier to maintain and scale**.
- Encourages **better organization** of logic.
- Helps map code closer to real-world thinking.

---

## 📦 The 4 Pillars of OOP

1. **Encapsulation** – hiding data and exposing controlled interfaces.
2. **Abstraction** – showing only essential features, hiding internal complexity.
3. **Inheritance** – enabling reuse by creating hierarchies (e.g. `Animal` → `Dog`).
4. **Polymorphism** – allowing the same operation to behave differently across objects.

*We will discuss these pillars in more detail in another lesson. In this one, we focus mainly on the theory behind OOP.*
---

## ⚖️ OOP vs Procedural Programming

| Procedural Programming         | Object-Oriented Programming         |
|--------------------------------|-------------------------------------|
| Code organized in functions    | Code organized in objects           |
| Data and logic are separate    | Data and logic are encapsulated     |
| Harder to maintain at scale    | Easier to maintain and extend       |
| Reuse via copy-paste           | Reuse via inheritance & composition |

---

## 📚 Real-World Analogy

Imagine designing a library system:

- `Book`, `User`, and `Librarian` are all classes.
- You interact with objects like `book.Borrow(user)` instead of calling raw functions.
- A `Librarian` may inherit from `User`, but with added capabilities.
- A common interface like `IBorrowable` allows treating books, DVDs, and magazines the same way.

---

## ✅ Goal of This Lesson

- Understand what OOP is and why it's useful.
- Learn the key vocabulary and mental models.
- See a simple code example contrasting procedural and object-oriented approaches.

---

🟢 **Next Lesson → [Class vs Struct vs Record](../_02_ClassVsStruct/README.md)** (coming soon)

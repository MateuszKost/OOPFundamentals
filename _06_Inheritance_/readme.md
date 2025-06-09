# 🧬 Lesson: Inheritance – "is-a" Relationships in C#

## ✅ What is Inheritance?

Inheritance is a core pillar of Object-Oriented Programming that allows one class to **inherit** properties and behavior (methods) from another.

> This helps promote **code reuse**, **hierarchical classification**, and **polymorphic behavior**.

---

## 📦 In This Lesson

We demonstrate inheritance using a simple **Animal hierarchy**:

- `Animal` – Base (parent) class with common properties (`Name`, `Age`) and a method `Describe()`
- `Dog` and `Cat` – Derived (child) classes that inherit from `Animal` and override the `MakeSound()` method

---
~~~~
## 🧠 Key Concepts

- ✅ **"Is-a" Relationship**:  
  A `Dog` **is an** `Animal`, so it can inherit from it.

- ✅ **Base Class**:  
  Holds shared behavior (e.g. `Name`, `Age`, `Describe()`)

- ✅ **Derived Class**:  
  Inherits from base class and may override/extend its behavior

- ✅ **Virtual/Override**:  
  Enables polymorphism — derived classes can modify base class behavior.

---

## 🧪 Try It Yourself

Run the program and explore:

- Creating instances of `Dog` and `Cat`
- Calling methods from the base class (`Describe`)
- Calling overridden methods (`MakeSound`)

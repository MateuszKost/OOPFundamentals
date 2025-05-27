# Lesson: Encapsulation in C#

## What is Encapsulation?

Encapsulation is one of the core pillars of Object-Oriented Programming (OOP).  
It refers to the practice of **hiding an object’s internal state** and **exposing behavior via public methods or controlled access properties**.

> It ensures that objects maintain control over their own data and prevent accidental or invalid changes.

---

## In This Lesson

We build a `BankAccount` class to demonstrate encapsulation using C# properties and access modifiers.

### Key Concepts Illustrated

- **Private fields** — store data securely and are hidden from the outside:
  - `_balance` and `_ownerName` can only be accessed or modified internally.
- **Encapsulated properties** — control visibility using `get`, `set`, and access modifiers:
  - `Balance` has a **private setter**, meaning only internal code can change it (e.g. in `Deposit` or `Withdraw` methods).
  - `OwnerName` uses a `set` accessor with **custom validation logic** to ensure it’s never empty or whitespace.
  - `AccountNumber` uses a **read-only auto-property** (`{ get; }`), set via constructor and immutable afterward.
- **Public methods** — safely expose functionality:
  - `Deposit(decimal amount)`
  - `Withdraw(decimal amount)`

---

## Access Control with `get`, `set`, and Modifiers

In C#, you can fine-tune how properties behave using combinations of `get`, `set`, and access modifiers.

| Syntax                                         | Meaning                                                                 |
|------------------------------------------------|-------------------------------------------------------------------------|
| `public string Name { get; set; }`             | Fully accessible property – can be read and written from anywhere.              |
| `public decimal Balance { get; private set; }` | Readable publicly, but only the class itself can modify it.        |
| `public string AccountNumber { get; }`         | Read-only from outside – only set inside constructor or initializer.            |

---

## Why Use Encapsulation?

- **Protects internal state** from accidental modification
- **Improves maintainability** by centralizing logic (e.g., all validation lives in one place)
- **Promotes clear APIs** — consumers of your class use methods/properties without needing internal knowledge

---

## Try It Yourself

Run the program and observe:

- Valid deposits and withdrawals
- Invalid withdrawals (e.g., withdrawing more than balance) are blocked
- Direct access to internal state (e.g., `_balance`) is not allowed from outside the class

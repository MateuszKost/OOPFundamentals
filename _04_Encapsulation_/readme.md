# Lesson: Encapsulation in C#

## What is Encapsulation?

Encapsulation is one of the core pillars of Object-Oriented Programming (OOP).  
It refers to the practice of **hiding an object’s internal state** and **exposing behavior via public methods or controlled access properties**.

> It ensures that objects maintain control over their own data and prevent accidental or invalid changes.

---

## In This Lesson

We build a `BankAccount` class to demonstrate encapsulation using C# properties and access modifiers:

### Key Concepts Illustrated

- **Private fields** — store data securely:
  - `_balance` and `_ownerName` can only be accessed internally.
- **Encapsulated properties** — use `get` and `set` to control access:
  - `Balance` has a private setter, ensuring only internal operations (like `Deposit`) can change it.
  - `OwnerName` includes validation logic in its setter.
  - `AccountNumber` is initialized through the constructor and exposed as read-only.
- **Public methods** — validate and update internal state safely:
  - `Deposit(decimal amount)`
  - `Withdraw(decimal amount)`

---

## Why Use Encapsulation?

- Prevents external code from putting your object in an invalid state
- Makes maintenance easier — internal changes don’t affect outside code
- Encourages clear interfaces between different parts of your system

---

## Try It Yourself

Run the program and see how:

- Invalid withdrawals are blocked
- Deposits/withdrawals are processed safely
- Direct access to internal data is denied

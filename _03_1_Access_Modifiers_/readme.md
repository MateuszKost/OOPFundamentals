# Access Modifiers: Person and Employee Example

This project demonstrates C# access modifiers through two classes: `Person` and `Employee`.

---

## What Are Access Modifiers?

Access modifiers control the visibility and accessibility of class members to ensure proper encapsulation and secure data handling.

---

## Access Modifiers Explained in This Example

| Modifier             | Accessible From                                    | Usage in Example                                |
|----------------------|----------------------------------------------------|-------------------------------------------------|
| `private`            | Within the same class only                         | `_age` field                                    |
| `private protected`  | Subclasses within the same assembly only           | `PrivateProtectedNote` property                 |
| `protected`          | Same class and subclasses even in other assemblies | `SecretNickname` field, `RevealSecret()` method |
| `internal`           | Anywhere within the same assembly/project          | `InternalCode` property                         |
| `protected internal` | Subclasses anywhere OR anywhere in assembly        | `ProtectedInternalInfo` property                |
| `public`             | Everywhere                                         | `Name` property                                 |

---

## Project Structure

- **Person.cs**  
  Contains fields and properties using all discussed access modifiers, and methods to access private/protected data.

- **Employee.cs**  
  Inherits from `Person` and accesses all accessible members demonstrating how modifiers behave in derived classes.

- **Program.cs**  
  Runs a demonstration creating an `Employee` and printing accessible data to the console.

---

## What You’ll Learn

- How to safely expose data using `public` methods while keeping fields `private`.
- The difference between `protected` and `private protected` access levels.
- How `internal` and `protected internal` broaden access within assemblies.
- How access modifiers affect inheritance and visibility in derived classes.

---

## Running the Project

Run the `Program.cs` to see output showcasing access to various members according to their access modifiers.

---

Explore and modify the code to better understand how to design robust, secure classes using C# access modifiers!

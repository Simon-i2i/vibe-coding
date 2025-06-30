# Learning Object-Oriented Programming (OOP) with C#

Welcome! This project is designed to teach the four main pillars of Object-Oriented Programming (OOP) using simple, real-world examples. OOP is a way of writing computer programs by thinking about code in the same way we think about things in the real world. We create "objects" that have properties (data) and can perform actions (methods).

## How to Run This Project

1.  Make sure you have the .NET 8.0 SDK installed.
2.  Open a terminal or command prompt.
3.  Navigate to this folder (`src/Oops`).
4.  Run the command: `dotnet run --project Oops.csproj`

You will see the output from all the examples.

---

## The Four Pillars of OOP

### 1. Encapsulation (Keeping Things Secure)

**The Big Idea:** Encapsulation is like putting things in a secure box. You can't just reach in and change what's inside directly. You have to use the special slots or buttons on the outside of the box. This keeps the internal data safe and prevents accidental mistakes.

**Our Example (`BankAccount.cs`):**
*   We have a `BankAccount` object that holds your money (the `balance`).
*   The `balance` is `private`, meaning nothing from the outside can touch it directly.
*   To change the balance, you must use the public methods `Deposit()` and `Withdraw()`. These methods contain important rules (like not withdrawing more money than you have).
*   This "encapsulates" the balance, protecting it with a layer of secure methods.

### 2. Abstraction (Hiding Complexity)

**The Big Idea:** Abstraction is about hiding all the complicated details of how something works and only showing the simple controls you need to use it.

**Our Example (`Device.cs`):**
*   Think of a **Television and its Remote Control**. The remote has simple buttons: `TurnOn`, `VolumeUp`, `ChangeChannel`.
*   When you press `TurnOn`, a lot of complex things happen inside the TV (powering up, loading software, etc.), but you don't need to know about any of that. All that complexity is hidden.
*   Abstraction provides a simple interface (`RemoteControl`) to a complex system (`Television`).

### 3. Inheritance (Reusing and Building Upon)

**The Big Idea:** Inheritance is like family traits. Children inherit features from their parents. In OOP, we can create a general "parent" class and then create more specific "child" classes that inherit all the parent's features and add some of their own.

**Our Example (`Animal.cs`):**
*   We have a general `Animal` class that has a `Name` and can `Eat()`.
*   We then create a `Dog` class and a `Cat` class that **inherit** from `Animal`.
*   This means both `Dog` and `Cat` automatically get a `Name` and know how to `Eat()` without us having to write that code again.
*   They can also have their own unique actions (`Dog` can `Fetch()`, `Cat` can `Purr()`) and can provide their own version of a parent's action (a `Dog`'s `MakeSound()` is "Woof!", while a `Cat`'s is "Meow!").

### 4. Polymorphism (One Action, Many Forms)

**The Big Idea:** Polymorphism means "many forms". It's the idea that you can give the same command to different objects, and each object will respond in its own unique way.

**Our Example (`Shape.cs`):**
*   We have a general `Shape` class with a `Draw()` action.
*   We have specific shapes like `Circle`, `Square`, and `Triangle` that are all types of `Shape`.
*   We can make a list of different shapes and tell every shape in the list to `Draw()` itself.
*   Even though we use the exact same command (`shape.Draw()`), the `Circle` object draws a circle, the `Square` object draws a square, and so on. One command has many different outcomes depending on the object.

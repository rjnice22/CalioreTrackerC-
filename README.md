

https://youtu.be/diRjMsqssqI

# Food Log Application - SQLite Integration

### Developer
**Rico Johnson-Hall**

### Date
09/27/2025

---

## 🧩 Overview
The **Food Log Application** is a simple C# console project that demonstrates **object-oriented programming** and **database integration** using **SQLite**.  
It allows users to add, view, update, delete, and total their calorie intake through a menu-driven interface.

---

## 🏗️ Project Structure

| File | Description |
|------|--------------|
| **User.cs** | Defines the `User` class, representing a single user in the system. Demonstrates encapsulation and constructor use. |
| **FoodLog.cs** | Defines the `FoodLog` class, representing an individual food entry. Demonstrates composition, constructors, and encapsulation. |
| **FoodLogManager.cs** | Handles all CRUD (Create, Read, Update, Delete) operations using **SQL commands**. Demonstrates abstraction and database interaction. |
| **DatabaseHelper.cs** | Responsible for creating and initializing the SQLite database and tables (`Users` and `FoodLogs`). Demonstrates static utility classes and schema creation. |
| **Program.cs** | Contains the main program logic and console menu system. Demonstrates user interaction, input handling, and procedural control flow. |

---

## 🧠 Key Concepts Demonstrated
- **Encapsulation**: Each class protects its internal data with private setters and exposes only necessary methods.
- **Abstraction**: Database logic is separated into the `DatabaseHelper` and `FoodLogManager` classes.
- **Composition**: The `FoodLogManager` works with `FoodLog` and `User` objects to form a cohesive system.
- **Data Persistence**: All information is stored in a local `FoodLogs.db` SQLite file.
- **CRUD Operations**: Add, read, update, and delete entries through SQL commands.

---

## 🖥️ How to Run
1. Open the project in **Visual Studio** or **VS Code**.
2. Ensure the **System.Data.SQLite** NuGet package is installed:


# CalorieTrackerC-

### Author
Rico Johnson-Hall III  
**Course:** SDC320 – Software Development Using C#  
**Assignment:** Calorie Tracker Application  
**Date:** October 2025  

---

## 📖 Overview
CalorieTrackerC- is a C# application designed to help users record and monitor their daily calorie intake.  
It demonstrates core programming concepts including object-oriented design, database integration, and file management — all implemented using Visual Studio and SQLite.

---

## 🎯 Project Goals
- Implement **data persistence** using SQLite for storing calorie entries  
- Apply **object-oriented programming** principles (encapsulation, abstraction, etc.)  
- Demonstrate **CRUD operations** (Create, Read, Update, Delete) in a real-world context  
- Provide a simple, menu-driven **console interface** (expandable to WPF or MAUI later)

---

## 🧩 File Structure

CalorieTrackerC-/
├── Models/
│ └── Entry.cs # Defines data structure for each food entry
├── DataAccess/
│ └── DatabaseManager.cs # Handles database connection and CRUD logic
├── Program.cs # Main entry point, user menu and app flow
├── CalorieTrackerC-.csproj # Visual Studio project configuration
├── App.config # Connection string and runtime settings (if used)
└── README.md # Project documentation


---

## 🧠 Key Concepts Demonstrated
- **Encapsulation:** Data members in `Entry` are private with public getters/setters  
- **Abstraction:** `DatabaseManager` hides low-level SQL commands behind easy methods  
- **Composition:** `Program.cs` uses `DatabaseManager` and `Entry` together to build functionality  
- **Persistence:** SQLite provides long-term data storage within a lightweight local DB file  
- **Error Handling:** Try/catch blocks prevent crashes during database operations

---

## ⚙️ Technologies Used
- **Language:** C# (.NET 8.0 compatible)  
- **IDE:** Visual Studio 2022  
- **Database:** SQLite (via System.Data.SQLite)  
- **Platform:** Console Application  

---

## 🧪 How to Run
1. Open `CalorieTrackerC-.sln` in Visual Studio  
2. Build the solution (Ctrl + Shift + B)  
3. Run the app (Ctrl + F5)  
4. Follow the menu prompts to add, view, update, or delete entries  

A database file named `calorieTracker.db` will be automatically created in the project’s output folder.

---

## 🔍 Future Enhancements
- Convert into a .NET MAUI app with graphical UI  
- Add login profiles and daily goal tracking  
- Integrate charts for calorie visualization  
- Enable cloud sync with user accounts  

---

## 💬 Author’s Note
This project served as a hands-on demonstration of connecting theoretical OOP concepts with practical database operations. It lays the groundwork for future development into a mobile or cross-platform health-tracking app.


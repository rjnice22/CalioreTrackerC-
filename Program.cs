/*
 * Developer: Rico JohnsonHall
 * Date: 09/27/2025
 * Assignment: Food Log Application - Database Integration
 * Description: Console menu for interacting with the Food Log system.
 */

using System;
using System.Data.SQLite;

namespace FoodLogApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabaseHelper.InitializeDatabase();

            User user = new User(1, "Rico");
            EnsureUserExists(user);

            FoodLogManager manager = new FoodLogManager();
            ShowMainMenu(user, manager);
        }

        private static void EnsureUserExists(User user)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string sql = "INSERT OR IGNORE INTO Users (UserID, Name) VALUES (@id, @name)";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", user.UserID);
                    cmd.Parameters.AddWithValue("@name", user.Name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void ShowMainMenu(User user, FoodLogManager manager)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== FOOD LOG MENU =====");
                Console.WriteLine("1. Add Log");
                Console.WriteLine("2. View Logs");
                Console.WriteLine("3. Update Log");
                Console.WriteLine("4. Delete Log");
                Console.WriteLine("5. Calculate Total Calories");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter food name: ");
                        string food = Console.ReadLine();
                        Console.Write("Enter calories: ");
                        int calories = int.Parse(Console.ReadLine());

                        FoodLog newLog = new FoodLog(0, user.UserID, food, calories, DateTime.Now);
                        manager.AddLog(newLog);
                        break;

                    case "2":
                        manager.ViewLogs();
                        break;

                    case "3":
                        Console.Write("Enter LogID to update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter new food name: ");
                        string newFood = Console.ReadLine();
                        Console.Write("Enter new calories: ");
                        int newCals = int.Parse(Console.ReadLine());

                        manager.UpdateLog(updateId, newFood, newCals);
                        break;

                    case "4":
                        Console.Write("Enter LogID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        manager.DeleteLog(deleteId);
                        break;

                    case "5":
                        int total = manager.CalculateTotalCalories();
                        Console.WriteLine($"Total Calories: {total}");
                        break;

                    case "6":
                        running = false;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}

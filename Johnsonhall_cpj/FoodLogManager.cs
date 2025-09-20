/*
 * Developer: Rico JohnsonHall
 * Date: 09/19/2025
 * Assignment: Food Log Application
 */

using System;
using System.Collections.Generic;

namespace FoodLogApp
{
    public class FoodLogManager
    {
        public List<FoodLog> Logs { get; private set; }

        public FoodLogManager()
        {
            Logs = new List<FoodLog>();
        }

        // Add a log
        public void AddLog(FoodLog log)
        {
            Logs.Add(log);
            Console.WriteLine("Log added successfully!");
        }

        // Update a log
        public void UpdateLog(int logID, string newFood, int newCalories)
        {
            FoodLog log = Logs.Find(l => l.LogID == logID);
            if (log != null)
            {
                log.Update(newFood, newCalories);
                Console.WriteLine("Log updated successfully!");
            }
            else
            {
                Console.WriteLine("Log not found.");
            }
        }

        // Delete a log
        public void DeleteLog(int logID)
        {
            FoodLog log = Logs.Find(l => l.LogID == logID);
            if (log != null)
            {
                Logs.Remove(log);
                Console.WriteLine("Log deleted successfully!");
            }
            else
            {
                Console.WriteLine("Log not found.");
            }
        }

        // View all logs
        public void ViewLogs()
        {
            if (Logs.Count == 0)
            {
                Console.WriteLine("No logs available.");
                return;
            }

            foreach (FoodLog log in Logs)
            {
                Console.WriteLine(log);
            }
        }

        // Calculate total calories
        public int CalculateTotalCalories()
        {
            int total = 0;
            foreach (FoodLog log in Logs)
            {
                total += log.Calories;
            }
            return total;
        }
    }
}

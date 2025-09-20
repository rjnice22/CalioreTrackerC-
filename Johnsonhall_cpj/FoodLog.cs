/*
 * Developer: Rico JohnsonHall
 * Date: 09/19/2025
 * Assignment: Food Log Application
 */

using System;

namespace FoodLogApp
{
    public class FoodLog
    {
        // Properties
        public int LogID { get; private set; }
        public int UserID { get; private set; }
        public string FoodName { get; private set; }
        public int Calories { get; private set; }
        public DateTime DateTimeConsumed { get; private set; }

        // Constructor
        public FoodLog(int logId, int userId, string foodName, int calories, DateTime consumed)
        {
            LogID = logId;
            UserID = userId;
            FoodName = foodName;
            Calories = calories;
            DateTimeConsumed = consumed;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"LogID: {LogID}, Food: {FoodName}, Calories: {Calories}, Date: {DateTimeConsumed}";
        }

        // Update helper method
        public void Update(string newFood, int newCalories)
        {
            FoodName = newFood;
            Calories = newCalories;
        }
    }
}

/*
 * Developer: Rico JohnsonHall
 * Date: 09/27/2025
 * Assignment: Food Log Application - Database Integration
 * Description: Represents a food log entry.
 */

using System;

namespace FoodLogApp
{
    public class FoodLog
    {
        public int LogID { get; private set; }
        public int UserID { get; private set; }
        public string FoodName { get; private set; }
        public int Calories { get; private set; }
        public DateTime DateTimeConsumed { get; private set; }

        public FoodLog(int logId, int userId, string foodName, int calories, DateTime consumed)
        {
            LogID = logId;
            UserID = userId;
            FoodName = foodName;
            Calories = calories;
            DateTimeConsumed = consumed;
        }

        public override string ToString()
        {
            return $"LogID: {LogID}, Food: {FoodName}, Calories: {Calories}, Date: {DateTimeConsumed}";
        }

        public void Update(string newFood, int newCalories)
        {
            FoodName = newFood;
            Calories = newCalories;
        }
    }
}

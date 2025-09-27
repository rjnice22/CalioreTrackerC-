/*
 * Developer: Rico JohnsonHall
 * Date: 09/27/2025
 * Assignment: Food Log Application - Database Integration
 * Description: Manages CRUD operations for FoodLogs via SQLite.
 */

using System;
using System.Data.SQLite;

namespace FoodLogApp
{
    public class FoodLogManager
    {
        public void AddLog(FoodLog log)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO FoodLogs (UserID, FoodName, Calories, DateTimeConsumed) VALUES (@uid, @food, @cal, @dt)";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@uid", log.UserID);
                    cmd.Parameters.AddWithValue("@food", log.FoodName);
                    cmd.Parameters.AddWithValue("@cal", log.Calories);
                    cmd.Parameters.AddWithValue("@dt", log.DateTimeConsumed.ToString("s"));
                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Log added successfully!");
        }

        public void UpdateLog(int logID, string newFood, int newCalories)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string sql = "UPDATE FoodLogs SET FoodName=@food, Calories=@cal WHERE LogID=@id";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@food", newFood);
                    cmd.Parameters.AddWithValue("@cal", newCalories);
                    cmd.Parameters.AddWithValue("@id", logID);
                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine(rows > 0 ? "Log updated successfully!" : "Log not found.");
                }
            }
        }

        public void DeleteLog(int logID)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string sql = "DELETE FROM FoodLogs WHERE LogID=@id";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", logID);
                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine(rows > 0 ? "Log deleted successfully!" : "Log not found.");
                }
            }
        }

        public void ViewLogs()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string sql = "SELECT LogID, UserID, FoodName, Calories, DateTimeConsumed FROM FoodLogs";
                using (var cmd = new SQLiteCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("No logs available.");
                        return;
                    }

                    while (reader.Read())
                    {
                        int logId = reader.GetInt32(0);
                        int userId = reader.GetInt32(1);
                        string food = reader.GetString(2);
                        int calories = reader.GetInt32(3);
                        DateTime dt = DateTime.Parse(reader.GetString(4));

                        Console.WriteLine($"LogID: {logId}, UserID: {userId}, Food: {food}, Calories: {calories}, Date: {dt}");
                    }
                }
            }
        }

        public int CalculateTotalCalories()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string sql = "SELECT SUM(Calories) FROM FoodLogs";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
        }
    }
}

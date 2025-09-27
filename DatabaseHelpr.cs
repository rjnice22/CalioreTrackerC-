/*
 * Developer: Rico JohnsonHall
 * Date: 09/27/2025
 * Assignment: Food Log Application - Database Integration
 * Description: Provides SQLite database connection and schema setup.
 */

using System.Data.SQLite;

namespace FoodLogApp
{
    public static class DatabaseHelper
    {
        private const string DbFile = "FoodLogs.db";
        private const string ConnectionString = "Data Source=" + DbFile + ";Version=3;";

        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS FoodLogs (
                    LogID INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserID INTEGER NOT NULL,
                    FoodName TEXT NOT NULL,
                    Calories INTEGER NOT NULL,
                    DateTimeConsumed TEXT NOT NULL,
                    FOREIGN KEY(UserID) REFERENCES Users(UserID)
                );";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }
    }
}

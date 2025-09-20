/*
 * Developer: Rico JohnsonHall
 * Date: 09/19/2025
 * Assignment: Food Log Application
 */

namespace FoodLogApp
{
    public class User
    {
        // Properties with encapsulation
        public int UserID { get; private set; }
        public string Name { get; private set; }

        // Constructor
        public User(int userId, string name)
        {
            UserID = userId;
            Name = name;
        }

        // Method to return info string
        public string GetUserInfo()
        {
            return $"UserID: {UserID}, Name: {Name}";
        }

        // Override ToString()
        public override string ToString()
        {
            return $"User: {Name}";
        }
    }
}

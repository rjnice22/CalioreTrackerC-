/*
 * Developer: Rico JohnsonHall
 * Date: 09/27/2025
 * Assignment: Food Log Application - Database Integration
 * Description: Represents a user of the food log system.
 */

namespace FoodLogApp
{
    public class User
    {
        public int UserID { get; private set; }
        public string Name { get; private set; }

        public User(int userId, string name)
        {
            UserID = userId;
            Name = name;
        }

        public string GetUserInfo()
        {
            return $"UserID: {UserID}, Name: {Name}";
        }

        public override string ToString()
        {
            return $"User: {Name}";
        }
    }
}

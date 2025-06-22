using System;
using System.Collections.Generic;
using UserManagementSystem.Models;

namespace UserManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<User> users = new List<User>();

            
            Admin admin = new Admin { UserName = "AdminUser", Email = "admin@example.com" };
            admin.SetPassword("admin123");

            Moderator moderator = new Moderator { UserName = "ModUser", Email = "mod@example.com" };
            moderator.SetPassword("mod123");

            RegularUser regularUser = new RegularUser { UserName = "RegUser", Email = "user@example.com" };
            regularUser.SetPassword("user123");

            users.Add(admin);
            users.Add(moderator);
            users.Add(regularUser);

            
            Console.WriteLine("=== User Information ===");
            foreach (var user in users)
            {
                Console.Write($"Name: {user.UserName} | Email: {user.Email} | ");
                if (user is Admin)
                    Console.WriteLine("Role: Administrator");
                else if (user is Moderator)
                    Console.WriteLine("Role: Moderator");
                else if (user is RegularUser)
                    Console.WriteLine("Role: Regular User");
            }

            
            Console.WriteLine("\n=== Method Testing ===");
            admin.BlockUser(regularUser);
            moderator.ModerateContent();
            regularUser.PostComment();

            
            Console.WriteLine("\n=== Authentication Check ===");
            var testPasswords = new Dictionary<string, string>
            {
                { "AdminUser", "admin123" },       
                { "ModUser", "wrongpassword" },    
                { "RegUser", "user123" }           
            };

            foreach (var user in users)
            {
                string inputPassword = testPasswords[user.UserName];

                bool isAuthenticated = user.Authenticate(inputPassword);
                string result = isAuthenticated ? "Authentication successful" : "Incorrect password";
                Console.WriteLine($"{user.UserName}: {result}");
            }
        }
    }
}

using System;

namespace UserManagementSystem.Models
{
    public class Admin : User
    {
        public void BlockUser(User user)
        {
            Console.WriteLine($"User {user.UserName} blocked.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Admin");
        }
    }
}

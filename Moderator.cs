using System;

namespace UserManagementSystem.Models
{
    public class Moderator : User
    {
        public void ModerateContent()
        {
            Console.WriteLine("Content modarated.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Moderator");
        }
    }
}

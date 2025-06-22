using System;

namespace UserManagementSystem.Models
{
    public class RegularUser : User
    {
        public void PostComment()
        {
            Console.WriteLine("Comment published.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: User ");
        }
    }
}

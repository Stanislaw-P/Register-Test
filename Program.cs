using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class User
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public User(string firstName, string email)
        {
            FirstName = firstName;
            Email = email;
        }

        public override string ToString()
        {
            return $"{FirstName} - {Email}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Кактус", "kaktus@mail.com");
            using (StreamWriter fileForWrite = new StreamWriter(@"users\data.txt", true))
            {
                fileForWrite.WriteLine(user1);
            }
            Console.WriteLine("Registration completed");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordRegistrationLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                
                Dictionary<string, string> usernames = new Dictionary<string, string>();

                List<string> username = new List<string>();
                Console.WriteLine("Please input your username, must contain letters and numbers, be at least 5 letters, and a total of 7 characters long. ");
                string user = UserInput1("Username is: ");
                Console.ReadLine();
                
                Console.WriteLine(username);
                UserName(user);

                Dictionary<string, string> passwords = new Dictionary<string, string>();

                List<string> password = new List<string>();
                Console.WriteLine("Please create a password with at least one lower and upper case letter, one number, be a minimum of 7 characters and max of 12, and contain a special character of: !, @, #, $, %, ^, &, *");
                string pass = UserInput2("Password is: ");
                Console.ReadLine();
                Console.WriteLine(password);
                PassWord(pass);
                
            }
            
            

            
        }
        public static string UserInput1(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }
        public static string UserInput2(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }
        public static bool UserName(string username)
        {
            if (username.Length < 5 || username.Length > 7)
            {
                Console.WriteLine("Line 1");
                return false;
            }
            if (!username.Any(char.IsUpper))
            {
                Console.WriteLine("Line 2");
                return false;
            }
            if (!username.Any(char.IsLower))
            {
                Console.WriteLine("Line 3");
                return false;
            }
            if (username.Contains(" "))
            {
                Console.WriteLine("Line 4");
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public static bool PassWord(string password)
        { 

            if (password.Length < 7 || password.Length > 12)
            {
                Console.WriteLine("Line 5");
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Line 6");
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                Console.WriteLine("Line 7");
                return false;
            }
            if (password.Contains(" "))
            {
                Console.WriteLine("Line 8");
                return false;
            }
            else
            {
                return true;
            }

            char[] specialChr = specialChr.ToCharArray;
            char[] specialChr = { '!', '@', '#', '$', '%', '^', '&', '*' };
            foreach (char ch in specialChr)
            {
                if (password.Contains(ch))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        

    }
}

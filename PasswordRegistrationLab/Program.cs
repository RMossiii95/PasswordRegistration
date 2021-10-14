using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordRegistrationLab
{
    class Program
    {
        
        static List<string> usernames = new List<string>();        
        static List<string> passwords = new List<string>();
        static void Main(string[] args)
        {
            bool tryAgain = true;
            while (tryAgain == true)
            {

                List<string> username = new List<string>();
                Console.WriteLine("Please input your username, must contain letters and numbers, be at least 5 letters, and a total of 7 characters long. ");
                string user = UserInput1("Username is: ");



                if (UserName(user))
                {
                    username.Add(user);
                    usernames.Add(username[0]);
                }





                List<string> password = new List<string>();
                Console.WriteLine("Please create a password with at least one lower and upper case letter, one number, be a minimum of 7 characters and max of 12, and contain a special character of: !, @, #, $, %, ^, &, *");
                string pass = UserInput2("Password is: ");



                if (PassWord(pass))
                {
                    password.Add(pass);
                    passwords.Add(password[0]);
                }

                for (int i = 0; i < usernames.Count; i++)
                {
                    Console.WriteLine(usernames[i]);
                }

                for (int i = 0; i < passwords.Count; i++)
                {
                    Console.WriteLine(passwords[i]);
                }
                Console.WriteLine(usernames);
                Console.WriteLine(passwords);
            }
            tryAgain = Continue();



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
            Console.WriteLine(username + username.Length);
            if (username.Length < 5 || username.Length > 7)
            {
                Console.WriteLine("Error 1: That input was either too long or small.");
                return false;
            }
            if (!username.Any(char.IsUpper))
            {
                Console.WriteLine("Error 2");
                return false;
            }
            if (!username.Any(char.IsLower))
            {
                Console.WriteLine("Error 3");
                return false;
            }
            if (username.Contains(" "))
            {
                Console.WriteLine("Error 4: There was a space in your input, please give a new username.");
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
                Console.WriteLine("Error 5: Your password is either too short or too long.");
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Error 6: You are missing an upper case character!");
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                Console.WriteLine("Error 7: You are missing a lower case character!");
                return false;
            }
            if (password.Contains(" "))
            {
                Console.WriteLine("Error 8: There was a space in your password, please try again!");
                return false;
            }
            else
            {
                return true;
            }

            
            char[] specialChr = { '!', '@', '#', '$', '%', '^', '&', '*' };
            foreach (char ch in specialChr)
            {
                if (password.Contains(ch))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Error 9: Your password did not contain a special character, please try again!");
                    return false;
                }

            }
        }
        public static bool Continue()
        {
            string response = UserInput1("Would you like to try again? y/n");
            

            if (response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                Console.WriteLine("Good bye!");
                return false;

            }
            else
            {
                Console.WriteLine("That was not a valid response, please try again!");
                return Continue();
            }
        }






        }
}

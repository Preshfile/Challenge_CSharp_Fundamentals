using Microsoft.Win32;
using System;
using System.Linq;

namespace If_Statements_Assessment
{
    internal class Program
    {
        //create a global varriable to be used by all the methods
        static string userName = "AmakaLucky";
        static string password = "Ami4Lucky@Lag";

        static void Main(string[] args)
        {
            // Challenge: 
            // Create a user Login System, where the user can first register and then Login in.
            // The Program should check if the user has entered the correct username and password,
            // when login in (so the same ones that he used when registering).
            // As we haven't covered storing data yet, just create the program in a way,
            // that registering and logging in, happen in the same execution of it.
            // User If statements and User Input and Methods to solve the challenge.

            UserLoginAndRegistrationSystem();
            Console.Read();
        }

        public static void UserLoginAndRegistrationSystem()
        {
            Console.WriteLine("Are you a registered user? Yes or No?");
            string registeredOrNot = Console.ReadLine();

            if (registeredOrNot.ToLower().Equals("yes"))
            {
                //calling the Login method 
                Login();
            }
            else
            {
                //calling the Register method 
                Register();
            }
        }

        public static void Login()
        {
            Console.WriteLine("\nEnter your Username");
            string myUserName = Console.ReadLine();

            if (myUserName.Equals(userName))
            {
                Console.WriteLine("Enter your password\n");
                string myPassword = Console.ReadLine();

                if (myPassword.Equals(password))
                {

                    Console.WriteLine("Your login was successful");
                }
                else
                {
                    Console.WriteLine("\nIncorrect Password");
                }
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

        public static void Register()
        {
            Console.WriteLine("Provide the following registration details:\n");

            Console.WriteLine("Your User Name:");
            string myNewUserName = Console.ReadLine();

            if (!myNewUserName.Equals(userName))
            {
                Console.WriteLine("Username Accepted!");

                Console.WriteLine("Provide a password");
                string myNewPassword = Console.ReadLine();

                if (!IsWeakPassword(myNewPassword))
                {
                    Console.WriteLine("Registration Successful");
                }
                else
                {
                    Console.WriteLine("Weak Password! Must be up to 8 characters with upper and lower cases, special character and number");
                }
            }
            else
            {
                Console.WriteLine("The username already exist, Try another name");
            }
        }

        public static bool IsWeakPassword(string password)
        {
            // Check if the password length is less than or equal to 8 characters
            if (password.Length >= 8)
            {
                // Check if the password contains at least one uppercase letter
                if (password.Any(char.IsUpper))
                {
                    // Check if the password contains at least one lowercase letter
                    if (password.Any(char.IsLower))
                    {
                        // Check if the password contains at least one special character
                        if (password.Any(c => "!@#$%^&*()-_=+[]{};:'\"<>,.?/".Contains(c)))
                        {
                            // If all conditions are met, the password is not weak
                            if (password.Any(char.IsDigit))
                            {
                                // If all conditions are met, the password is not weak
                                return false;
                            }
                        }
                    }
                }
            }

            // If any of the conditions are not met, the password is weak
            return true;
        }
    }
}
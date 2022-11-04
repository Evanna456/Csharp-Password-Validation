using System;

namespace Csharp_Password_Validation
{
    internal class Program
    {
        public static void program()
        {
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            checkLength(password, 6, 24);
            checkUpperCase(password);
            checkNumber(password);
            checkRepeatedLetters(password);
            Console.WriteLine("OK!");
        }
        public static void checkLength(string password, int min, int max)
        {
            int password_length = password.Length;
            if (password_length < min || password_length > max)
            {
                Console.WriteLine("Password should be " + min + " to " + max + " characters long");
                Environment.Exit(0);
            }
        }
        public static void checkUpperCase(string password)
        {
            int password_length = password.Length;
            int uppercase_chars = 0;
            for (int it = 0; it < password_length; it++)
            {
                if (Char.IsUpper(password[it]) == true)
                {
                    uppercase_chars = uppercase_chars + 1;
                }
            }
            if (uppercase_chars == 0)
            {
                Console.WriteLine("Password should atleast have 1 uppercase letter");
                Environment.Exit(0);
            }
        }
        public static void checkLowerCase(string password)
        {
            int password_length = password.Length;
            int lowercase_chars = 0;
            for (int it = 0; it < password_length; it++)
            {
                if (Char.IsLower(password[it]) == true)
                {
                    lowercase_chars = lowercase_chars + 1;
                }
            }
            if (lowercase_chars == 0)
            {
                Console.WriteLine("Password should atleast have 1 lowercase letter");
                Environment.Exit(0);
            }
        }
        public static void checkNumber(string password)
        {
            int password_length = password.Length;
            int number_chars = 0;
            for (int it = 0; it < password_length; it++)
            {
                if (Char.IsDigit(password[it]) == true)
                {
                    number_chars = number_chars + 1;
                }
            }
            if (number_chars == 0)
            {
                Console.WriteLine("Password should atleast have 1 number");
                Environment.Exit(0);
            }
        }
        public static void checkRepeatedLetters(string password)
        {
            try
            {
                int password_length = password.Length;
                int repeated_letters = 0;
                for (int it = 0; it < password_length; it += 3)
                {
                    if (password[it] != null)
                    {
                        if (password[it] == password[it + 1] && password[it] == password[it + 2])
                        {
                            repeated_letters = repeated_letters + 1;
                        }
                    }
                }
                if (repeated_letters > 0)
                {
                    Console.WriteLine("There are repeated characters");
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
            }
        }
        public static void checkSpecialChar(string password)
        {
            string allowed_special_chars = "!@#$%^&*()+=_-{}[]:;\"'?<>,.";
            int password_length = password.Length;
            int illegal_characters = 0;
            for (int it = 0; it < password_length; it++)
            {
                if (Char.IsLetterOrDigit(password[it]) == false)
                {
                    if (allowed_special_chars.Contains(password[it]) == false)
                    {
                        illegal_characters = illegal_characters + 1;
                    }
                }
            }
            if (illegal_characters > 0)
            {
                Console.WriteLine("Invalid special character/s");
                Environment.Exit(0);
            }
        }
        private static void Main(string[] args)
        {
            program();
        }
    }
}
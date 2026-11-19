
using System;
using System.Text.RegularExpressions;

namespace RegExPracticalWork
{
    class Program
    {
        // Task 1: Login validation
        static bool ValidateLogin(string login)
        {
            string pattern = @"^[\p{L}][\p{L}\p{N}]{1,9}$";

            return Regex.IsMatch(login, pattern);
        }

        // Task 2: Word filter
        static string FilterWords(string text)
        {
            string pattern = @"\bbad(?:ly|ness)?\b";

            return Regex.Replace(
                text,
                pattern,
                "good",
                RegexOptions.IgnoreCase
            );
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== REGEX PROGRAM =====");

            // TASK 1: LOGIN VALIDATION
            Console.WriteLine("\n===== TASK 1: LOGIN VALIDATION =====");

            Console.Write("Enter your login: ");
            string login = Console.ReadLine();

            if (ValidateLogin(login))
            {
                Console.WriteLine("Login is valid!");
            }
            else
            {
                Console.WriteLine("Login is invalid!");
                Console.WriteLine(
                    "Login must contain 2-10 characters."
                );
                Console.WriteLine(
                    "Only letters and digits are allowed."
                );
                Console.WriteLine(
                    "The first character must be a letter."
                );
            }

            // TASK 2: WORD FILTER
            Console.WriteLine("\n===== TASK 2: WORD FILTER =====");

            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();

            string result = FilterWords(text);

            Console.WriteLine("\nOriginal text:");
            Console.WriteLine(text);

            Console.WriteLine("\nFiltered text:");
            Console.WriteLine(result);

            Console.WriteLine("\nProgram completed successfully!");

            Console.ReadKey();
        }
    }
}

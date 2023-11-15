using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RegexAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please enter a piece of text:");
           string userInput = Console.ReadLine();
            //
            //Counting words using regular expression
            int wordCount = Regex.Matches(userInput, @"[\S]+").Count;
           //Task-1 
            Console.WriteLine($"You entered: {userInput}");
            //task-2 
              Console.WriteLine($"Word count: {wordCount}");
            //task-3
            Console.WriteLine("Please enter the email:Example in format of 'username@domain'");
            string email = Console.ReadLine();
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(email);
            if(regex.IsMatch(email)) 
            {
                Console.WriteLine($"valid email id: {email}");
            }
            else 
            {
                Console.WriteLine($"invalid email id: {email} ");
            }
            //task-4
            Console.WriteLine("Enter your mobile Nmumber E.g.6304971938");
            string mobilenumber = Console.ReadLine();
            string mobilepattern = @"\b\d{10}\b";
            Regex rx = new Regex(mobilenumber);
            if (rx.IsMatch(mobilenumber))
            {
                Console.WriteLine($"valid phone number {mobilenumber}");
            }
            else
            {
                Console.WriteLine($"Invalid mobile number {mobilenumber}");
            }
            //task-5
            Console.WriteLine("Enter the text to search:");
            string text = Console.ReadLine();

            Console.WriteLine("Enter the custom regular expression:");
            string spattern = Console.ReadLine();
            Regex sregex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            if (matches.Count > 0)
            {
                Console.WriteLine($"Matches found ({matches.Count}):");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("No matches found.");
            }
            //task-6
            Console.WriteLine($"You entered: {userInput}");
            Console.WriteLine($"Word count: {wordCount}");
            Console.WriteLine($"valid email id: {email}");
            Console.WriteLine($"valid phone number {mobilenumber}");
            Console.ReadKey();    
        }
    }
}    
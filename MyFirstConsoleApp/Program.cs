using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.GetUserNameAndLocation();
            Program.ChristmasCountdown(2020, 10, 4);
            GlazerApp.RunExample();

        }

        static void GetUserNameAndLocation()
        {
            Person person1 = new Person();

            Console.Write("What is your name? ");
#pragma warning disable CS8601 // Possible null reference assignment.
            person1.name = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
            Console.Write("Hi, " + person1.name + ", where are you from? ");
#pragma warning disable CS8601 // Possible null reference assignment.
            person1.location = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
            Console.WriteLine("I have never been to " + person1.location + ". I bet it is nice.");

        }

        static void ChristmasCountdown(int year, int month, int day)
        {
            DateTime date1 = new DateTime(year, month, day);
            DateTime localDate = DateTime.Now.Date;
            Console.WriteLine("The current date is " + localDate.ToShortDateString());

            DateTime Xmas = new DateTime(DateTime.Now.Year, 12, 25);
            TimeSpan diff = (Xmas - DateTime.Now);
            Console.WriteLine(diff.Days + " Days till Christmas.");

        }
    }
}

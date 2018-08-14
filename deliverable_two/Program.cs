using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable_two
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro statement, giving the user instruction.
            Console.WriteLine("Welcome to David's 'Difference Between Dates'");
            Console.WriteLine("Please give me two dates (formatted yyyy/mm/dd), and I will calculate how many days are between them.");
            Console.WriteLine("Ex: If first day is 2000/01/01 and second day is 2018/08/14, then there are 6800 days between them.");
            Console.WriteLine("Don't try to break me! I will know if your inputs are invalid!");
            Console.WriteLine("");

            // Ask the user for their first date.
            Console.WriteLine("Please type your first date, then press enter:");

            // Check format on user's first date. If incorrect, try again.
            string s1 = Console.ReadLine();
            while (!DateTime.TryParse(s1, out DateTime result))
            {
                Console.WriteLine("Your date is not the proper format. Try again:");
                s1 = Console.ReadLine();
            }

            // Stores user's first date as variable date1.
            DateTime date1 = Convert.ToDateTime(s1);

            // Same process for second date.
            Console.WriteLine("Now for your second number:");
            string s2 = Console.ReadLine();
            while (!DateTime.TryParse(s2, out DateTime result))
            {
                Console.WriteLine("Your date is not the proper format. Try again:");
                s2 = Console.ReadLine();
            }
            DateTime date2 = Convert.ToDateTime(s2);

            // Calculate the difference between the dates.
            TimeSpan difference = (date2 - date1);

            /* Use variables to display difference as days, hours, and minutes. 
            The absolute value function is used so the order of the user's dates doesn't matter.*/
            double difDay = Math.Abs(difference.TotalDays);
            double difHour = Math.Abs(difference.TotalHours);
            double difMin = Math.Abs(difference.TotalMinutes);

            // Return answer to the user, then finish.
            Console.WriteLine("");
            Console.WriteLine("The difference between " + date1 + " and " + date2 + ":");
            Console.WriteLine("");
            Console.WriteLine(difDay + " days");
            Console.WriteLine("Which is " + difHour + " hours, or " + difMin + " minutes.");
            Console.WriteLine("");
            Console.WriteLine("Thank you for using my program! Press any key to close.");
            Console.ReadKey();
            
        }
    }
}

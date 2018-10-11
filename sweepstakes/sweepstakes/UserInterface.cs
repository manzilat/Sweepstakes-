using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class UserInterface
    {
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            Console.Write("Please Enter Selector:   ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string GetContestantFirstName()
        {
            string userInput = GetUserInput("Please enter your first name: ");
            return userInput;
        }
        public static string GetContestantLastName()
        {
            string userInput = GetUserInput("Please enter your last name: ");
            return userInput;
        }
        public static string GetContestantEmailAddress()
        {
            string userInput = GetUserInput("Please enter your email address: ");
            return userInput;
        }
        public static Guid SetRegistrationNumber()
        {
            Guid newGuid;
            newGuid = Guid.NewGuid();
            return newGuid;
        }
    }
}

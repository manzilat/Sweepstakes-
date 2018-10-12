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
            Console.Write("Please Enter Selection:   ");


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
        public static string GetManagerType()
        {
            string managerType = GetUserInput("Select Required Manager:\n[1] Stack Manager\n[2] Queue Manager");
            return managerType;
        }
        public static Sweepstakes CreateSweepstake()
        {
            Sweepstakes newSweepstake = new Sweepstakes();
            return newSweepstake;
        }
        public static string DoneAddingContestants()
        {
            string userInput = GetUserInput("Add more contestants? [yes] [no] ");
            return userInput;
        }
        public static string DetermineSweepstakeAction()
        {
            string userInput = GetUserInput("What would you like to do?\n[1] Add Contestants\n[2] View Contestants\n[3] Determin Winner\n[4] Exit");
            return userInput;
        }
        public static string DetermineMarketingFirmAction()
        {
            string userInput = GetUserInput("What would you like to do?\n[1] Get Sweepstake\n[2] Insert Sweepstake\n[3] Change Manager Type\n[4] Exit Application");
            return userInput;
        }
    }
    }


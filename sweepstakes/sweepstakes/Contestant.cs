using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public Guid registrationNumber;

        public Contestant()
        {
            firstName = UserInterface.GetContestantFirstName();
            lastName = UserInterface.GetContestantLastName();
            emailAddress = UserInterface.GetContestantEmailAddress();
            registrationNumber = UserInterface.SetRegistrationNumber();
        }
    }
}

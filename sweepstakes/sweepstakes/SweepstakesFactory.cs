using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepstakesFactory
    {
        public ISweepstakesManager DetermineManager(string managerType)
        {
            switch (managerType)
            {
                case "1":
                    return new SweepstakesQueueMananger();
                case "2":
                    return new SweepstakesStackManager();
                default:
                    return DetermineManager(managerType);
            }
        }
    }
}

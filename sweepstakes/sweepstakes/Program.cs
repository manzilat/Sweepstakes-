using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                SweepstakesFactory sweepstakesFactory = new SweepstakesFactory();
                MarketingFirm newFirm = new MarketingFirm(sweepstakesFactory.DetermineManager(UserInterface.GetManagerType()));
                newFirm.DetermineMarketFirmAction();
            }
        }
    }
}

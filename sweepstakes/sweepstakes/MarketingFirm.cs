using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager sweepstakesManager;
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesManager.GetSweepstakes();
        }
        public void InsertSweepstakes()
        {
            sweepstakesManager.InsertSweepstakes(UserInterface.CreateSweepstake());
        }
        public void DetermineMarketFirmAction()
        {
            while (true)
            {
                switch (UserInterface.DetermineMarketingFirmAction())
                {
                    case "1":
                        GetSweepstakes();
                        break;
                    case "2":
                        InsertSweepstakes();
                        break;
                    case "3":
                        return;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        DetermineMarketFirmAction();
                        break;
                }
            }
        }
    }
}

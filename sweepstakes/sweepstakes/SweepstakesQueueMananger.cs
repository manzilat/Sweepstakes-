using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepstakesQueueMnanger : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakesQueueStart = sweepstakesQueue.Dequeue();
            return sweepstakesQueueStart;
        }
    }
}

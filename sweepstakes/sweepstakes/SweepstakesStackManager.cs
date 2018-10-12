﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakesFromStack = sweepstakesStack.Pop();
            return sweepstakesFromStack;
        }
    }
}

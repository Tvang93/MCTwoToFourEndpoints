using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCTwoToFour.Services
{
    public class WakeUpTimeServices
    {
        public string wakeUpSentence = "";
        public string wakeUpTime(string userName, int wakeTime)
        {
            wakeUpSentence = $"{userName} woke up at {wakeTime} o'clock.";
            return wakeUpSentence;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCTwoToFour.Services
{
    public class AddTwoNumbersServices
    {
        public string sumSentence = "";
        public string AddTwoNumbers(int num1, int num2)
        {
            sumSentence = $"The sum of {num1} and {num2} is {num1 + num2}.";
            return sumSentence;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzRemainder
{
    public class FizzBuzzRemainder
    {
        public int LowerLimit { get; set; }
        public int UpperLimit { get; set; }
        private Dictionary<int, string> NumberAndWordPairs { get; set; }

        public FizzBuzzRemainder()
        {
            LowerLimit = 1;
            UpperLimit = 100;
        }

        public FizzBuzzRemainder(int lowerLimit = 1,
                                    int upperLimit = 100)
        {
            LowerLimit = lowerLimit;
            UpperLimit = upperLimit;
        }

        /// <summary>
        /// This method Counts from the lower limit to the upper limit (defined as properties either passed in 
        /// by the constructor or set directly in conjunction with the default constructor) and for each
        /// iteration determintes if one of the keys are divisble by the number (counter) with no remainder.
        /// </summary>
        /// <param name="numberAndWordPairs">Key/Value Pair for a number that is checked to be divisible by and the text to display if it is.</param>
        public void CountNumbers(Dictionary<int, string> numberAndWordPairs)
        {
            List<string> list = new List<string>();

            if (numberAndWordPairs == null)
            {
                throw new System.ArgumentNullException();
            }

            if (numberAndWordPairs.Count == 0)
            {
                throw new System.ArgumentException();
            }

            if (UpperLimit < LowerLimit)
            {
                throw new System.ArgumentOutOfRangeException();
            }

            for (int i = LowerLimit; i <= UpperLimit; i++)
            {
                bool found = false;

                foreach (var pair in numberAndWordPairs)
                {
                    if (i % pair.Key == 0)
                    {
                        System.Diagnostics.Debug.Write(pair.Value + " ");
                        found = true;
                    }
                }

                if (found == false)
                {
                    System.Diagnostics.Debug.WriteLine(i.ToString());
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("");
                }
            }
        }       
    }
}

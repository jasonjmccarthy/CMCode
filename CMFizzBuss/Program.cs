using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMFizzBuss
{
    class Program
    {
        public static void Main(string[] args)
        {          
            // Key / Value Pairs and Upper and lower Limits could very well have been stored in a config file,
            // database, etc but I'm just simulating that by setting them directly in this client console application.
            const int LOWERLIMIT = -20;
            const int UPPERLIMIT = 200;
            
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(2, "POP");
            keyValuePairs.Add(3, "FIZZ");
            keyValuePairs.Add(5, "BUZZ");
            keyValuePairs.Add(7, "CRACKLE");         

            FizzBuzzRemainder.FizzBuzzRemainder fizzBuzzRemainder = new FizzBuzzRemainder.FizzBuzzRemainder(LOWERLIMIT, UPPERLIMIT);
            
            try
            {
                fizzBuzzRemainder.CountNumbers(keyValuePairs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.Read();
        }

        /// <summary>
        /// This method was the original logic to support just values 3 and 5 counting from 1 to 100. 
        /// This is not being used.
        /// </summary>
        private static void WriteToConsole()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizz BUZZ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}

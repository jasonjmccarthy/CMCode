using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzUnitTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        Dictionary<int, string> keyValuePairs;            

        [TestInitialize]
        public void SetupTest()
        {
            keyValuePairs = new Dictionary<int, string>();

            keyValuePairs.Add(2, "POP");
            keyValuePairs.Add(3, "FIZZ");
            keyValuePairs.Add(5, "BUZZ");
            keyValuePairs.Add(7, "CRACKLE");
        }

        /// <summary>
        /// 1. Test if setting an upper limit is smaller than the lower limit then an ArgumentOutOfRangeException exeption is thrown.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UpperLimitHigherThanLowerLimit()
        {
            int lowerlimit = 50;
            int upperlimit = 30;
           
            FizzBuzzRemainder.FizzBuzzRemainder fizzBuzzRemainder = new FizzBuzzRemainder.FizzBuzzRemainder(lowerlimit, upperlimit);           
            fizzBuzzRemainder.CountNumbers(keyValuePairs);            
        }

        /// <summary>
        /// 2.	Test if the key/value pairs passed to the primary method is null then ArgumentNullException execption is thrown.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void KeyValuePairIsNull()
        {
            int lowerlimit = 30;
            int upperlimit = 50;

            keyValuePairs = null;

            FizzBuzzRemainder.FizzBuzzRemainder fizzBuzzRemainder = new FizzBuzzRemainder.FizzBuzzRemainder(lowerlimit, upperlimit);
            fizzBuzzRemainder.CountNumbers(keyValuePairs);
        }

        /// <summary>
        /// 3.	Test if the key/value pairs object has no items inside an ArgumentException exeption is thrown.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void KeyValuePairIsEmpty()
        {
            int lowerlimit = 30;
            int upperlimit = 50;

            keyValuePairs.Clear();

            FizzBuzzRemainder.FizzBuzzRemainder fizzBuzzRemainder = new FizzBuzzRemainder.FizzBuzzRemainder(lowerlimit, upperlimit);
            fizzBuzzRemainder.CountNumbers(keyValuePairs);
        }
    }
}

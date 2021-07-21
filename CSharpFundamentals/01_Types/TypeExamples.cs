using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes();
        {
            //Whole Numbers
          byte oneBytesWorth;
          oneBytesWorth = 255;
            short smallWholeNumber = 16;
        int standardWholeNumber = 32;
        long largeWholeNumber = 64;

        //Decimals
        float floatExample = 1.234f;
        double doubleExample = 1.234;
        decimal decimalExample = 1.234m;

        char letter = 'j';

        //Operators
        int numOne = 17;
        int numTwo = 5;
        int sum = numOne + numTwo;
        int diff = numOne - numTwo;
        int prod = numOne * numTwo;
        int quot = numOne / numTwo;
        int remainder = numOne % numTwo;

        }
    }
}

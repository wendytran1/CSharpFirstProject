using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {

        //Input
        //What we do
        //Output

        //Access Modifier -- Return Type -- Method Signature (Name and List of parameter) -- Body Part (down 1 or more spaces)

        public int addTwoNumbers (int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int subtractTwoNumbers (int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int multipleTwoNumbers (int x, int y)
        {
            int prod = x * y;
            return prod;
        }

        private int divideTwoNumbers (int 50, int 2)
        {
            int division = 50 / 2;
            return division;
        }

        private int findRemainder (int 9, int 2)
        {
            int remainder = 9 % 2;
            return remainder;
        }

        [TestMethod]
        public void MethodTests()
        {
            int sum = addTwoNumbers(7, 12); //7 and 12 are two arguments accordingly to numOne and numTwo
            int cherry = addTwoNumbers(5, 42);

            Assert.AreEqual(19, sum); //we're asserting that 19 and sum (line 49) are equal

            int subtractedSum = subtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedSum);

            int product = multipleTwoNumbers(12, 5);
            Assert.AreEqual(60, product);

            int division = divideTwoNumbers(10, 4);
            Assert.AreEqual(2, division);

            int remainder = findRemainder(10, 4);
            Assert.AreEqual(2, remainder);
        }
    }
}

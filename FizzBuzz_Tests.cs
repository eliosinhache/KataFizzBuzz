using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataFizzBuzz.Exercises;
using Xunit;

namespace KataFizzBuzz
{
    [TestClass]
    public class FizzBuzz_Tests
    {
        [Theory]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "fizz")]
        [DataRow(4, "4")]
        [DataRow(5, "buzz")]
        [DataRow(7, "7")]
        [DataRow(15, "fizzbuzz")]
        [TestMethod]
        public void Fizz_Buzz_Test(int num, string expected)
        {
            SolutionKata sk = new SolutionKata();
            //Act
            var result = sk.IsFizzOrBuzzOrWhat(num);

            //Assert
            Assert.AreEqual(expected, result);
            
        }
    }
}

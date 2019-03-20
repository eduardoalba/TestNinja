using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(1, "1", TestName = "GetOuput_InputIsNotDivisibleBy3Or5_ReturnTheSameNumber")]
        [TestCase(3, "Fizz", TestName = "GetOuput_InputIsDivisibleBy3Only_ReturnFizz")]
        [TestCase(5, "Buzz", TestName = "GetOuput_InputIsDivisibleBy5Only_ReturnBuzz")]
        [TestCase(15, "FizzBuzz", TestName = "GetOuput_InputIsDivisibleBy3And5_ReturnFizzBuzz")]
        public void GetOuput_WhenCalled_ReturnValue(int value, string exceptedValue)
        {
            var result = FizzBuzz.GetOutput(value);

            Assert.That(result, Is.EqualTo(exceptedValue));
        }
    }
}

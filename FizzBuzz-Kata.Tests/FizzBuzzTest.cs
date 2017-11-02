using NFluent;
using NUnit.Framework;

namespace FizzBuzz_Kata.Tests
{
    public class FizzBuzzTest
    {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void Should_Return_()
        {
            int input = 1;

            string output = fizzBuzz.Compute(input);

            Check.That(output).IsEqualTo(1.ToString());
        }
    }
}

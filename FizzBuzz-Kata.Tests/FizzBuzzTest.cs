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

            Check.That(output).IsEqualTo("1");
        }

        [TestCase(3)]
        [TestCase(3)]
        [TestCase(9)]
        public void Should_Return_Fizz_When_Input_Is_Multiple_Of_3(int input)
        {
            string output = fizzBuzz.Compute(input);

            Check.That(output).IsEqualTo("Fizz");
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(50)]
        public void Should_Return_Buzz_When_Input_Is_Multiple_Of_5(int input)
        {
            string output = fizzBuzz.Compute(input);

            Check.That(output).IsEqualTo("Buzz");
        }

        [TestCase(15)]
        [TestCase(30)]
        public void Should_Return_FizzBuzz_When_Input_Is_Multiple_Of_3_And_Of_5(int input)
        {
            string output = fizzBuzz.Compute(input);

            Check.That(output).IsEqualTo("FizzBuzz");
        }
    }
}

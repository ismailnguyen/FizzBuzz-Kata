namespace FizzBuzz_Kata
{
    public class FizzBuzz
    {
        public string Compute(int input)
        {
            if (isMultipleOf(input, 3) && isMultipleOf(input, 5))
            {
                return "FizzBuzz";
            }

            if (isMultipleOf(input, 5))
            {
                return "Buzz";
            }

            if (isMultipleOf(input, 3))
            {
                return "Fizz";
            }

            return input.ToString();
        }

        private bool isMultipleOf(int input, int multiple)
        {
            return input % multiple == 0;
        }
    }
}
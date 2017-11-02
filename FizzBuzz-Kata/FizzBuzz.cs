namespace FizzBuzz_Kata
{
    public class FizzBuzz
    {
        public string Compute(int input)
        {
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
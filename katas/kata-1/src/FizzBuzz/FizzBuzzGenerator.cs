namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            List<string> numbers = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                if (i % 15 == 0)
                    numbers.Add("FizzBuzz");
                else if (i % 3 == 0)
                    numbers.Add("Fizz");
                else if (i % 5 == 0)
                    numbers.Add("Buzz");
                else
                    numbers.Add(i.ToString());
            }
            
            return numbers;
        }
    }
}
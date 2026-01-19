namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var numbers = new List<string>(count);

            for (int i = 1; i <= count; i++)
            {
                numbers.Add(GetFizzBuzzValue(i));
            }
    
            return numbers;
        }

        private static string GetFizzBuzzValue(int number)
        {
            if (number % 15 == 0) return "FizzBuzz";
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();
        }
    }
}
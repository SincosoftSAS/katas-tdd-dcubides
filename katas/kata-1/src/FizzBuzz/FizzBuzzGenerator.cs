namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            List<string> numbers = new List<string>();
            numbers.Add(count.ToString());
            return numbers;
        }
    }
}
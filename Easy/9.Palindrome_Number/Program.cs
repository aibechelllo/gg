internal class Program
{
    private static void Main(string[] args)
    {
        int x = 1239;

        Console.WriteLine(IsPalindrome(x));
    }

    public static bool IsPalindrome(int x)
    {
        if (x == 0)
            return true;

        var firstNumberToString = x.ToString();
        
        var secondNumberToString = "";

        while(x >= 1)
        {
            var currentNumber = (x % 10).ToString();

            secondNumberToString += currentNumber;

            x /= 10;
        }

        return firstNumberToString.Equals(secondNumberToString);
    }

}
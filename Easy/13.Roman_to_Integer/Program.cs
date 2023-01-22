internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(RomanToInt("IV"));
    }

    public static int RomanToInt(string s)
    {
        int sum = 0;

        Dictionary<char, int> romanSymbolsDictionary = new()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        for (int i = 0; i < s.Length; i++)
        {
            char currentRomanChar = s[i];
            romanSymbolsDictionary.TryGetValue(currentRomanChar, out int num);
            if (i + 1 < s.Length && romanSymbolsDictionary[s[i + 1]]> romanSymbolsDictionary[currentRomanChar])
            {
                sum -= num;
            }
            else
            {
                sum += num;
            }
        }
        return sum;
    }
}
class Program
{
    /// <summary>
    /// Method that determines if the input string is a palindrome
    /// </summary>
    /// <param name="input">input string</param>
    /// <returns>true/false</returns>
    static bool IsPalindrome(string input)
    {
        Stack<char> reverse = new Stack<char>();
        Queue<char> straight = new Queue<char>();

        foreach (char c in input) { reverse.Push(c); straight.Enqueue(c); }     //каждый символ строки помещяет в стек и очередь

        for (int i = 0; i < input.Length / 2 + 1; i++)                              //проверяем каждый символ с конца и начала строки на равенство
        {
            char s = straight.Dequeue();
            char r = reverse.Pop();
            //Console.WriteLine(s + " " + r);                                   //(опционально) вывод каждой итерации в консоль
            if (s != r) return false;                                           //при любом несвопадении, возвращаем false
        }
        return true;
    }
    static void Main(string[] args)
    {
        string? input = Console.ReadLine();

        bool inputIsPalindrome = IsPalindrome(input);

        Console.WriteLine(inputIsPalindrome ?
            $"The input string, \"{input}\", is a palindrome." :
            $"The input string, \"{input}\", is not a palindrome.");
    }
}
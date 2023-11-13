using System;

class DigitsLettersAndOthers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string digits = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                digits += input[i];
            }
        }
        Console.WriteLine(digits);

        string letters = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]))
            {
                letters += input[i];
            }
        }
        Console.WriteLine(letters);

        string others = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (!char.IsDigit(input[i]) && !char.IsLetter(input[i]))
            {
                others += input[i];
            }
        }
        Console.WriteLine(others);
    }
}

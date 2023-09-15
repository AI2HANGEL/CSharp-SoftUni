using System;

class Program
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        string _operator = Console.ReadLine();
        double result = 0;
        string evenOdd = "";
        bool divideError = false;

        if (_operator == "+")
        {
            result = numberOne + numberTwo;
        }
        else if (_operator == "-")
        {
            result = numberOne - numberTwo;
        }
        else if (_operator == "*")
        {
            result = numberOne * numberTwo;
        }
        else if (_operator == "/")
        {
            if (numberTwo == 0)
            {
                divideError = true;
            }
            else
            {
                result = (double)numberOne / numberTwo;
            }
        }
        else if (_operator == "%")
        {
            if (numberTwo == 0)
            {
                divideError = true;
            }
            else
            {
                result = numberOne % numberTwo;
            }
        }

        if (_operator == "+" || _operator == "-" || _operator == "*")
        {
            if ((int)result % 2 == 0)
            {
                evenOdd = "even";
            }
            else
            {
                evenOdd = "odd";
            }
            Console.WriteLine($"{numberOne} {_operator} {numberTwo} = {result} - {evenOdd}");
        }
        else if (divideError)
        {
            Console.WriteLine($"Cannot divide {numberOne} by zero");
        }
        else if (_operator == "/")
        {
            Console.WriteLine($"{numberOne} {_operator} {numberTwo} = {result:F2}");
        }
        else if (_operator == "%")
        {
            Console.WriteLine($"{numberOne} {_operator} {numberTwo} = {result}");
        }
    }
}

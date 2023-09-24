using System.ComponentModel.Design;

double coins = double.Parse(Console.ReadLine());

int CoinsConv = (int)Math.Round(coins * 100);
int total_coins = 0;


while (CoinsConv != 0)
{
    if (CoinsConv >= 200)
    {
        CoinsConv -= 200;
        total_coins += 1;
    }

    else if (CoinsConv >= 100)
    {
        CoinsConv -= 100;
        total_coins += 1;
    }

    else if (CoinsConv >= 50)
    {
        CoinsConv -= 50;
        total_coins += 1;
    }
    else if (CoinsConv >= 20)
    {
        CoinsConv -= 20;
        total_coins += 1;
    }
    else if (CoinsConv >= 10)
    {
        CoinsConv -= 10;
        total_coins += 1;
    }
    else if (CoinsConv >= 5)
    {
        CoinsConv -= 5;
        total_coins += 1;
    }
    else if (CoinsConv >= 2)
    {
        CoinsConv -= 2;
        total_coins += 1;
    }
    else if (CoinsConv >= 1)
    {
        CoinsConv -= 1;
        total_coins += 1;
    }

}
Console.WriteLine(total_coins);





//using System;

//class Program
//{
//    static void Main()
//    {
//        double coins = double.Parse(Console.ReadLine());
//        int CoinsConv = (int)Math.Round(coins * 100);

//        int[] coinDenominations = { 200, 100, 50, 20, 10, 5, 2, 1 };
//        int totalCoins = 0;

//        foreach (int denomination in coinDenominations)
//        {
//            int numCoins = CoinsConv / denomination;
//            totalCoins += numCoins;
//            CoinsConv %= denomination;
//        }

//        Console.WriteLine(totalCoins);
//    }
//}

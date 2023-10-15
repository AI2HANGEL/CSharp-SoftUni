//static void MathPower(int a, int b)
//{
//    int result = 1;
//    for (int i = 1; i <= b; i++)
//    {

//        result *= a;

//    }
//    Console.WriteLine(result);
//}
////alternative solution using loops


static void MathPower(int a, int b)
{
    Console.WriteLine((int)Math.Pow(a, b));
}


int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());

MathPower(numberOne, numberTwo);
static void RectangularAreaCalc(int a, int b)
{
    int area = a * b;
    Console.WriteLine(area);
}

int side_A = int.Parse(Console.ReadLine());
int side_B = int.Parse(Console.ReadLine());

RectangularAreaCalc(side_A, side_B);
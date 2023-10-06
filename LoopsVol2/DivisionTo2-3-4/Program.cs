int int_number = int.Parse(Console.ReadLine());

int div_by_two = 0;
int div_by_three = 0;
int div_by_four = 0;




for  (int i = 0; i < int_number; i++)
{
    int current_int = int.Parse(Console.ReadLine());

    if (current_int % 2 == 0)
    {
        div_by_two ++;
    }
    
    if (current_int % 3 == 0)
    {
        div_by_three ++;
    }

    if (current_int%4 == 0)
    {
        div_by_four ++;
    }
}

double perc_two = ((double)div_by_two / int_number) * 100;
double perc_three = ((double)div_by_three / int_number) * 100;
double perc_four = ((double)div_by_four / int_number) * 100;

Console.WriteLine($"{perc_two:F2}%");
Console.WriteLine($"{perc_three:F2}%");
Console.WriteLine($"{perc_four:F2}%");
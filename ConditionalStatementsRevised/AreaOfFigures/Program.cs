string figure = Console.ReadLine();
double area = 0;

switch (figure)
{
    case "square":
        double size_square = double.Parse(Console.ReadLine());
        area = size_square * size_square;
        break;

    case "rectangle":
        double size_rec_a = double.Parse(Console.ReadLine());
        double size_rec_b = double.Parse(Console.ReadLine());
        area = size_rec_a * size_rec_b;
        break;

    case "circle":
        double r = double.Parse(Console.ReadLine());
        area = Math.PI * (r * r);
        break;

    case "triangle":
        double size_tri_a = double.Parse(Console.ReadLine());
        double size_tri_h = double.Parse(Console.ReadLine());
        area = (size_tri_a * size_tri_h) / 2;
        break;

    default:
        Console.WriteLine("Invalid figure.");
        return;
}

Console.WriteLine($"{area:f2}");

namespace TheGreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_one = int.Parse(Console.ReadLine());
            int number_two = int.Parse(Console.ReadLine());

            if (number_one > number_two)

            {
                Console.WriteLine("Greater number: " + number_one);
            }
            else if (number_two > number_one)
            {
                Console.WriteLine("Greater number: " + number_two);

            }
            else
            {
                Console.WriteLine("The two numbers are equal.");
            }
        }
    }
}
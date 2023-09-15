namespace NumberName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            if (number == 1) 
            {
                Console.WriteLine("one");
            }
            else if (number == 2) 
            { 
                Console.WriteLine("two");
            }
            else if (number == 3) 
            {
                Console.WriteLine("three");
            }
            else if (number == 4)
            {
                Console.WriteLine("four");
            }
        }
    }
}
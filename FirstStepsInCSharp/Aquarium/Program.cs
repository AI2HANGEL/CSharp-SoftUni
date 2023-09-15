namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtcm = int.Parse(Console.ReadLine());
            int widthcm = int.Parse(Console.ReadLine());
            int heightcm = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;

            double volumeliters = (lenghtcm * widthcm * heightcm) * 0.001;

            double requiredliters = volumeliters * (1 - percentage);

            string formattedRequiredLiters = string.Format("{0:N2}", requiredliters);

            Console.WriteLine(formattedRequiredLiters);
        }
    }
}
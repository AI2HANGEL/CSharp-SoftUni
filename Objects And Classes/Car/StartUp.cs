using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarManufacturer
{
    internal class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            car.Make = "Kia";
            car.Model = "Ceed";
            car.Year = 2010;

        }
    }
}

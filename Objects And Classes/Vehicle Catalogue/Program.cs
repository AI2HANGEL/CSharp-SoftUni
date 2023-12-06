using System;
using System.Collections.Generic;
using System.Linq;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
}

class Truck : Vehicle
{
    public int Weight { get; set; }

    public override string ToString()
    {
        return $"{Brand}: {Model} - {Weight}kg";
    }
}

class Car : Vehicle
{
    public int HorsePower { get; set; }

    public override string ToString()
    {
        return $"{Brand}: {Model} - {HorsePower}hp";
    }
}

class Catalog
{
    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }

    public Catalog()
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();
    }

    public void AddVehicle(string type, string brand, string model, int value)
    {
        if (type == "Car")
        {
            Cars.Add(new Car { Brand = brand, Model = model, HorsePower = value });
        }
        else if (type == "Truck")
        {
            Trucks.Add(new Truck { Brand = brand, Model = model, Weight = value });
        }
    }

    public void PrintCatalog()
    {
        Console.WriteLine("Cars:");
        foreach (var car in Cars.OrderBy(c => c.Brand))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine("Trucks:");
        foreach (var truck in Trucks.OrderBy(t => t.Brand))
        {
            Console.WriteLine(truck);
        }
    }
}

class Program
{
    static void Main()
    {
        Catalog catalog = new Catalog();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] data = input.Split('/');
            string type = data[0];
            string brand = data[1];
            string model = data[2];
            int value = int.Parse(data[3]);

            catalog.AddVehicle(type, brand, model, value);
        }

        catalog.PrintCatalog();
    }
}

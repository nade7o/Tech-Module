using System;
using System.Collections.Generic;
using System.Linq;
namespace _6.VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string item = string.Empty;
            List<Vehicle> catalogue = new List<Vehicle>();
            List<Vehicle> modelsToPrint = new List<Vehicle>();
            int carCount = 0;
            int truckCount = 0;
            double carsHP = 0;
            double trucksHP = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    while (true)
                    {
                        item = Console.ReadLine();
                        if (item == "Close the Catalogue")
                        {
                            //Print info for models received after the End command
                            foreach (var vehicle in modelsToPrint)
                            {
                                Console.WriteLine("Type: {0}", vehicle.Type);
                                Console.WriteLine("Model: {0}", vehicle.Model);
                                Console.WriteLine("Color: {0}", vehicle.Color);
                                Console.WriteLine("Horsepower: {0}", vehicle.Horsepower);
                            }
                            foreach (var vehicle in catalogue)
                            {
                                if (vehicle.Type == "Car")
                                {
                                    carCount++;
                                    carsHP += vehicle.Horsepower;
                                }
                                else
                                {
                                    truckCount++;
                                    trucksHP += vehicle.Horsepower;
                                }
                            }
                            double carsAverage = carCount == 0 ? 0.00 : carsHP / carCount;
                            double trucksAverage = truckCount == 0 ? 0.00 : trucksHP / truckCount;

                            //Print average horse powers of car and trucks
                            Console.WriteLine("Cars have average horsepower of: {0:f2}.", carsAverage);
                            Console.WriteLine("Trucks have average horsepower of: {0:f2}.", trucksAverage);
                            return;
                        }
                        else
                        {
                            //Create list with the models which will be printed
                            foreach (var vehicle in catalogue)
                            {
                                if (vehicle.Model == item)
                                {
                                    modelsToPrint.Add(vehicle);
                                }
                            }
                        }
                    }

                }
                else
                {
                    //Enter vehicles in the catalogue
                    String[] data = input.Split(" ");
                    if (data[0] == "car")
                    {
                        data[0] = "Car";
                    }
                    else
                    {
                        data[0] = "Truck";
                    }
                    catalogue.Add(new Vehicle(data[0], data[1], data[2], int.Parse(data[3])));
                }
            }

        }
    }
}

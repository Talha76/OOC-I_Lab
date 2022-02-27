using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pleasant, comfy;
            double circumference, maxFuelConsumptionRate, maxEnergyProductionRate, avgRPM;
            string carName, seatWarmer, openingMode;
            Console.Write("Enter Car Name: ");
            carName = Console.ReadLine();

            Console.Write("Rate Seat Pleasant(1 - 10): ");
            pleasant = int.Parse(Console.ReadLine());

            Console.Write("Rate Seat Comfortability(1 - 10): ");
            comfy = int.Parse(Console.ReadLine());

            Console.Write("Is there a seat warmer?(y / n) ");
            seatWarmer = Console.ReadLine();

            Console.Write("Enter Wheel circumference: ");
            circumference = double.Parse(Console.ReadLine());

            Console.Write("Enter maximum fuel consumtion rate: ");
            maxFuelConsumptionRate = double.Parse(Console.ReadLine());

            Console.Write("Enter maximum energy production rate: ");
            maxEnergyProductionRate = double.Parse(Console.ReadLine());

            Console.Write("Enter average RPM: ");
            avgRPM = double.Parse(Console.ReadLine());

            Console.Write("Enter door opening mode: ");
            openingMode = Console.ReadLine();

            Car car = new Car(carName, pleasant, comfy, seatWarmer, circumference, 
                maxFuelConsumptionRate, maxEnergyProductionRate, avgRPM, openingMode);
            car.showInfo();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task01
{
    internal class Car
    {
        public string name { get; }
        private Seat seat;
        private Wheel wheel;
        private Engine engine;
        private Door door;
        public void showInfo()
        {
            Console.WriteLine("\n\nCar Details:\n\nSeat:\nPleasant = " + seat.pleasant + "\nComfortability = "
                + seat.comfy + "\nSeat Warmer = " + (seat.seatWarmer ? "Present" : "Absent")
                + "\n\nWheel:\nCircumference = " + wheel.circumference + "\n\nEngine:\n"
                + "Maximum Fuel Consumption Rate = " + engine.maxFuelConsumptionRate + "\n"
                + "Maximum Energy Production Rate = " + engine.maxEnergyProductionRate + "\n"
                + "Average RPM = " + engine.avgRPM + "\n\nDoor:\nOpening Mode = " + door.openingMode
                + "\n");
        }
        public Car(string name, int pleasant, int comfy, string seatWarmer, double circumference,
            double maxFuelConsumptionRate, double maxEnergyProductionRate, double avgRPM,
            string openingMode)
        {
            this.name = name;
            seat = new Seat(pleasant, comfy, seatWarmer == "y" ? true : false);
            wheel = new Wheel(circumference);
            engine = new Engine(maxFuelConsumptionRate, maxEnergyProductionRate, avgRPM);
            door = new Door(openingMode);
        }
    }
}

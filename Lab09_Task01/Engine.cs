using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task01
{
    sealed internal class Engine
    {
        public double maxFuelConsumptionRate { get; }
        public double maxEnergyProductionRate { get; }
        public double avgRPM { get; }
        public Engine (double maxFuelConsumptionRate, double maxEnergyProductionRate,
            double avgRPM)
        {
            this.maxFuelConsumptionRate = maxFuelConsumptionRate;
            this.maxEnergyProductionRate = maxEnergyProductionRate;
            this.avgRPM = avgRPM;
        }
    }
}

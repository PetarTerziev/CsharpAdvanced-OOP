using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        private int horsePower;
        private double fuel;
        public Vehicle(int horsePower, double fuel)
        {
            this.horsePower = horsePower;
            this.fuel = fuel;
        }

        public int HorsePower { get => horsePower; set => horsePower = value; }
        public double Fuel { get => fuel; set => fuel = value; }
        public virtual double FuelConsumption => DefaultFuelConsumption;

        public virtual void Drive(double kilometers) 
        {
            Fuel -= kilometers * this.FuelConsumption;
        }
    }
}

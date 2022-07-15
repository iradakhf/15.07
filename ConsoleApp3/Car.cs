using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Car : Vehicle
    {
        public int FuelCapacity { get; set; } = 100;
        public int CurrentFuel { get; set; } = 45;
        public int FuelForOneKm { get; set; } = 40;
        public Car(int fuelCapacity, int currentFuel, int fuelForOneKm)
        {
            this.FuelCapacity = 
        }
        public int Total { get; set; }
        public override string ShowInfo()
        {
            return base.ShowInfo();
        }
        public override void Drive()
        {
            int neededFuel = 0;
            if(Millage*FuelForOneKm< CurrentFuel)
            {
                CurrentFuel = CurrentFuel - (Millage * FuelForOneKm);
                Console.WriteLine(CurrentFuel);
            }
            else
            {
                CurrentFuel = (Millage * FuelForOneKm) - CurrentFuel;
                Console.WriteLine(CurrentFuel);
            }
        }
    }
}

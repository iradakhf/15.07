using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Millage { get; set; }
        public Vehicle(string color, string brand, int millage)
        {
            this.Color = color;
            this.Brand = brand;
            this.Millage = millage;
        }
        public virtual string ShowInfo()
        {
           return ($" {Color} { Brand} { Millage}");
        }
       
        public virtual void Drive()
        {
            Console.WriteLine();
        }
    }
}

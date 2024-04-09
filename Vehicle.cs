using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public int Millage { get; set; } 
        public int CurrentFuel { get; set; }
        public Vehicle()
        {

        }

        public Vehicle(string brand, string name, int millage, int currentFuel)
        {
            Brand = brand;
            Name = name;
            Millage = millage;
            CurrentFuel = currentFuel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab22
{
    public class Car:Vehicle
    {
        public int FuelCapacity { get; set; }
        public Car()
        {

        }

        public Car(string brand, string name, int millage,int fuelCapacity, int currentFuel) 
        {
            FuelCapacity = fuelCapacity;
            Brand= brand;
            Name = name;
           Millage= millage;
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
           
        }

        public void AddFuel()
        {

            FuelCapacity = 0;
            CurrentFuel= 20;
            int max = 100;
            int sum = 0;
            l1:
            Console.WriteLine("Yanacaq doldurma menteqesine xos gelmisiz...");
            Console.WriteLine("Nece litr yanacaq isteyirsiz..");
            int add=Convert.ToInt32(Console.ReadLine());
            if (add<max)
            {
                sum = CurrentFuel + add;
                FuelCapacity = sum;
                Console.WriteLine("Qabaqki benzin:"+CurrentFuel);
                Console.WriteLine("Indiki benzin:"+sum);
               goto l1;
                

            }
           

            else
            {
                Console.WriteLine("Sizin benzin deponuz doludur..");
                goto l1;
            }
        }
    }
}

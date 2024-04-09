namespace Lab22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car car =new Car
            {
                Brand="BMW",
                Name="M3",
                Millage=500,
                FuelCapacity=100,
                CurrentFuel=0,
            };
            car.AddFuel();
        }
    }
}
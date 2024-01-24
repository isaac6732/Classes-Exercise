namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "Toyota";
            car.Model = "Supra";
            car.Year = 1994;

            Car car2 = new Car()
            {
                Make = "Ferrari",
                Model = "SF90",
                Year = 2023
            };

            Car car3 = new Car("Hyundai", "Elantra", 2024);


            List<Car> carList = new List<Car>() { car, car2, car3 };
            
            foreach(Car cars in carList)
            {
                Console.WriteLine($"{cars.Make},{cars.Model},{cars.Year}");
            } 

        }

    }
}

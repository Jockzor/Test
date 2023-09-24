

using _0_1.Models;
using System.Security.Cryptography.X509Certificates;

namespace _0_1
{
   
    internal class Program
    {
      
        static void Main(string[] args)
        {
            bool exit = false;
            List<Car> listOfCars = new List<Car>();
                while (exit == false)
            {

                Console.WriteLine("Enter your model:");
                string model = Console.ReadLine()!;
                Console.WriteLine("Enter your color: ");
                string color = Console.ReadLine()!;
                Console.WriteLine("Enter horsepower: ");
                int horsePower = int.Parse(Console.ReadLine()!);

                Car car = new Car(model, color, horsePower);

                listOfCars.Add(car);
                
                car.PrintAllCars(listOfCars);

                if (car.FastCar() == true)
                    Console.WriteLine("This is a fast car");
                else Console.WriteLine("This is not a fast car");

                
                
            }
           

        }
    }
}
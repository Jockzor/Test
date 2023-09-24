
namespace _0_1.Models;

internal class Car
{
    private string model;
    private string color;
    private int horsePower;

    public Car(string aModel, string aColor, int aHorsePower)
    {
        Model = aModel;
        Color = aColor;
        HorsePower = aHorsePower;
    }
    public string Model { get=> model; set=> model = value.ToLower(); }
    
    public int HorsePower { get; set; }
    public string Color {
        get { return color; }
        set
        {
            if (value == "black")
                color = value;
            else
                Console.WriteLine("Entered Color was " + value);
            color = "Bad color";
            
        }
        }
    

  


    public bool FastCar()
    {
        if (HorsePower >= 200)
            return true;

        else return false;
    }

    public void PrintAllCars(List<Car> _listOfCars)
    {
        foreach (Car car in _listOfCars)
        {
            Console.WriteLine($"Model: {car.Model}, Color: {car.Color}, Horsepower: {car.HorsePower}");
        }
    }




}

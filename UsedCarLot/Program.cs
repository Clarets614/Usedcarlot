
using System.Linq;
using UsedCarLot;



List<Car> carList = new List<Car>() {
    new UsedCar("Batmobile", "Wayne Enterprises", 2024, 10000000, 1, 200000),
    new Car("Buick", "LeSabre", 1989, 2000, 2),
    new Car("Ferrari", "Enzo", 2023, 150000, 3),
    new UsedCar("Ford", "Focus", 2007, 1500, 4, 50000),
    new Car("Jeep", "Cherokee", 2024, 38000, 5),
    new UsedCar("Honda", "Civic", 2011, 10000, 6,115000)
};

Inventory(carList);

Console.WriteLine("Please pick you the make of your car.");

string userInput = Console.ReadLine();





AddCar(carList);

Inventory(carList);




//Methods

static void Inventory (List<Car> carList)

{
    foreach (var car in carList)
    {
        Console.WriteLine(car.ToString());
    }
}


static void AddCar(List <Car> carInv)
{

    int invNum = carInv.Max(c => c.inventory) + 1;
    //carInv.Add(new Car("test", "test", 2024, 500, 7));
    Console.WriteLine("Please enter the make of the car you would like to add");
    string make = Console.ReadLine().Trim();
    Console.WriteLine("Please enter the model of the car you would like to add");
    string model = Console.ReadLine().Trim();
    int year;
    do
    {
        Console.WriteLine("Please enter the year for the car you would like to add");
        if (int.TryParse(Console.ReadLine(), out year)) break;
    } while (true);
    decimal price;
    do
    {
        Console.WriteLine("Please enter the price of the car you would like to add");
        if(decimal.TryParse(Console.ReadLine(),out price)) break;
    } while (true);
    do
    {
        Console.WriteLine("Is this a used car? y/n");
        string input = Console.ReadLine().Trim().ToLower();
        if(input == "y")
        {
            
            double miles;
            do
            {
                Console.WriteLine("How many miles are on the car?");
                if(double.TryParse(Console.ReadLine(),out miles))
                {
                    carInv.Add(new UsedCar(make, model, year, price, invNum, miles));
                    break;
                }
            } while(true);
        }
        else if(input == "n")
        {
            carInv.Add(new Car(make, model, year, price, invNum));
            break;
        }

    }while(true);


}



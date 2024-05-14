
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
    carInv.Add(new Car("test", "test", 2024, 500, 7));

}



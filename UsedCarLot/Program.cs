
using UsedCarLot;

List<Car> carList = new List<Car>() {
    new UsedCar("Batmobile", "Wayne Enterprises", 2024, 10000000, 200000),
    new Car("Buick", "LeSabre", 1989, 2000),
    new Car("Ferrari", "Enzo", 2023, 150000),
    new UsedCar("Ford", "Focus", 2007, 1500, 50000),
    new Car("Jeep", "Cherokee", 2024, 38000),
    new UsedCar("Honda", "Civic", 2011, 10000, 115000)
};

foreach(var car in carList)
{
    Console.WriteLine(car.ToString());
}
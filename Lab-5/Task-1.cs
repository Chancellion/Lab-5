using System;
using System.Collections.Generic;
public abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}
public class Human
{
    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Людина ходить зi швидкiстю " + Speed);
    }
}
public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Машина їде зi швидкiстю " + Speed);
    }
}
public class Bus : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Автобус їде зi швидкiстю " + Speed);
    }
}
public class Train : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Трамвай їде зi швидкiстю " + Speed);
    }
}
public class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }

    public Route(string startPoint, string endPoint)
    {
        StartPoint = startPoint;
        EndPoint = endPoint;
    }

    public void CalculateOptimalRoute(Vehicle vehicle)
    {
        Console.WriteLine($"Обрахунок оптимального маршруту {vehicle.GetType().Name} з {StartPoint} до {EndPoint}");
    }
}
public class TransportNetwork
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ControlMovement()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Данiїл Iванченко, КIб-1-23-4.0д");
        Car car = new Car { Speed = 100, Capacity = 4 };
        Bus bus = new Bus { Speed = 60, Capacity = 40 };
        Train train = new Train { Speed = 120, Capacity = 200 };
        Human human = new Human { Speed = 5 };

        Route route = new Route("Київ", "Львiв");

        TransportNetwork network = new TransportNetwork();
        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);

        network.ControlMovement();

        route.CalculateOptimalRoute(car);
        route.CalculateOptimalRoute(bus);
        route.CalculateOptimalRoute(train);

        human.Move();
    }
}

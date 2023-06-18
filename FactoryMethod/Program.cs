using System;
using FactoryMethod.ex2;


class Program
{
    static void Main(string[] args)
    {
        new Client().Main();



        Console.WriteLine();


        VehicleFactory factory = new ConcreteVehicleFactory();

        IFactory scooter = factory.GetVehicle("Scooter");
        scooter.Drive(10);

        IFactory bike = factory.GetVehicle("Bike");
        bike.Drive(20);

        Console.ReadKey();
    }
}



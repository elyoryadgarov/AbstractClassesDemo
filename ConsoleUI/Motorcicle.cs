using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public string HasSideCart {get; set; }
    public string WheelsCount {get; set; }

    public Motorcycle(string model, string make, string year, string hasSideCart, string wheelsCount)
    {
        HasSideCart = hasSideCart;
        WheelsCount = wheelsCount;
        Console.WriteLine($"Full Details of the Motorcycle:");
        Console.WriteLine($"Brand: {make}, \nModel: {model} , \nYear: {year},  \nHas Side Cart: {hasSideCart}, \nWheels Count: {wheelsCount}.");
    }

    public override void DriveAbstract()
    {
        Console.WriteLine("Driving Abstract Implementation in a Motorcycle");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Driving Virtual Method Implementation in Motorcycle");
    }
}
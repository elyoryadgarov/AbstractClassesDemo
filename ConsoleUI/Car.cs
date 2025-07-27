using System;

namespace ConsoleUI;

public class Car  : Vehicle
{
    public string HasTrunk {get; set; }
    public string EngineType {get; set; }

    public Car(string model, string make, string year, string hasTrunk, string engineType)
    {
        HasTrunk = hasTrunk;
        EngineType = engineType;
        Console.WriteLine($"Full Details of the Car:");
        Console.WriteLine($"Brand: {make}, \nModel: {model} , \nYear: {year},  \nHasTrunk: {hasTrunk}, \nEngine Type: {engineType}.");
        
    }

    public override void DriveAbstract()
    {
        Console.WriteLine("Driving Abstract Implementation in a Car");
    }

}
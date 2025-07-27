using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    string Model { get; set; } = "Civic";
    string Make { get; set; } = "Honda";
    string Year { get; set; } =  "2020";
    
    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("Vehicle DriveVirtual");
    }

}
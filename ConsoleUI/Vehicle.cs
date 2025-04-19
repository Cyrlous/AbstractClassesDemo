using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    //Properties
    public string Year { get; set; } = "Year of Manufacture";
    public string Make { get; set; } = "Make of Vehicle";
    public string Model { get; set; } = "Model of Vehicle";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("Vehicle is driving.");
    }
}
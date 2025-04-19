using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public int NumberOfDoors {get; set;}


    public override void DriveAbstract()
    {
        Console.WriteLine("The car is cruising down the road.");
    }
}
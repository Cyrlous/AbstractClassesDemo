using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public override void DriveAbstract()
    {
        Console.WriteLine("The motorcycle cruises down the road.");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine($"The motorcycle blasts noisily around town.");
    }
}
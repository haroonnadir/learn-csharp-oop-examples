using System;

/*
 * Topic 1: What is OOP?
 *
 * Technical definition (English):
 * Object-Oriented Programming (OOP) organizes software around objects.
 * An object combines related data (state) and actions (behavior).
 *
 * Roman English:
 * OOP mein program ko objects ke gird organize karte hain. Har object ke
 * paas apna data hota hai aur us data se related actions hotay hain.
 *
 * Real-life example:
 * Car ka rang aur model uska data hai. Car ka start hona aur rukna uske actions hain.
 *
 * Is example ko chalane ke liye:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein, phir:
 *   dotnet run --project OopLesson
 */

class Car
{
    // Car ka rang store karne wala data.
    public string Color;

    // Car ko start karne wala action.
    public void Start()
    {
        Console.WriteLine($"The {Color} car is starting.");
    }
}

class Program
{
    static void Main()
    {
        // Car class ke naqshay se aik object banaya.
        Car myCar = new Car();

        // Is object ka rang set kiya.
        myCar.Color = "red";

        // Object ka Start action chalaya.
        myCar.Start();

        Console.WriteLine();
        Console.WriteLine("Exercise:");
        Console.WriteLine("Book naam ki class banayein, uska title store karein,");
        Console.WriteLine("aur ShowDetails action se title display karein.");
    }
}

using System;

/*
 * Topic 15: Single Inheritance
 *
 * Technical definition (English):
 * Single inheritance is a class relationship where one derived class inherits
 * directly from one base class.
 *
 * Roman English:
 * Single inheritance mein aik child class seedha aik hi parent/base class se
 * inherit karti hai.
 *
 * Real-life example:
 * Car aik Vehicle hai. Car, Vehicle ke common Brand aur Start behavior ko le
 * sakti hai, aur apna Model data add kar sakti hai.
 *
 * Syntax:
 * class Child : Parent
 * {
 * }
 *
 * C# class aik hi doosri class ko directly base class bana sakti hai.
 * Multiple interfaces implement karna mumkin hai; woh baad mein parhenge.
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Vehicle single base class hai.
class Vehicle
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public void Start()
    {
        Console.WriteLine($"{Brand} vehicle is starting.");
    }
}

// Car seedha sirf Vehicle se inherit karti hai.
class Car : Vehicle
{
    public string Model { get; set; }

    public Car(string brand, string model) : base(brand)
    {
        Model = model;
    }

    public void ShowModel()
    {
        Console.WriteLine($"Model: {Model}");
    }
}

class Program
{
    static void Main()
    {
        // Car object ko Brand parent constructor aur Model child constructor se milta hai.
        Car car = new Car("Toyota", "Corolla");

        // Inherited Vehicle method.
        car.Start();

        // Car class ka apna method.
        car.ShowModel();
    }
}

/*
 * Expected output:
 * Toyota vehicle is starting.
 * Model: Corolla
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ke liye hai.
 * - class Vehicle aik base class hai.
 * - Brand property har Vehicle ka brand rakhti hai.
 * - Vehicle(string brand) base constructor Brand set karta hai.
 * - Start() base class ka common method hai.
 * - class Car : Vehicle ka matlab Car aik hi class, Vehicle, se inherit karti hai.
 * - Model property Car ka apna data hai.
 * - Car(string brand, string model) derived class ka constructor hai.
 * - : base(brand) pehle Vehicle constructor call karke Brand set karta hai.
 * - Model = model; Car ka apna Model initialize karta hai.
 * - ShowModel() Car class ka apna method hai.
 * - Main() program ka starting point hai.
 * - new Car("Toyota", "Corolla") Car object banata hai.
 * - car.Start() inherited base method chalata hai.
 * - car.ShowModel() child class ka method chalata hai.
 *
 * Single inheritance ka faida:
 * Common behavior base class mein aik martaba likha ja sakta hai aur child
 * class usay inherit karke apna khaas behavior add kar sakti hai.
 *
 * Practice exercises:
 *
 * Beginner 1: Vehicle mein Year property add karein aur car ke saath display karein.
 * Beginner 2: Car mein Honk() method add karein.
 * Intermediate 1: Animal base class mein Name aur Eat() rakhein; Dog : Animal
 *                 mein Bark() add karein.
 * Intermediate 2: Parent constructor mein required value pass karne ke liye
 *                  : base(...) ka istemal karein.
 * Real-world scenario: Account base class mein AccountNumber aur ShowAccount()
 *                      rakhein; SavingsAccount us se inherit kare.
 *
 * Aap ki bari:
 * Animal base class banayein jismein Name aur Eat() hon. Dog : Animal class
 * banayein jismein Bark() ho. Constructor se Name set karein, phir inherited
 * Eat() aur Dog ka Bark() call karein. Code bhejein; main check karunga.
 */

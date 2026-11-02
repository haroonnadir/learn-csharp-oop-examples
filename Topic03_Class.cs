using System;

/*
 * Topic 3: Class
 *
 * Technical definition (English):
 * A class is a programmer-defined type that describes the data and behavior
 * its objects can have.
 *
 * Roman English:
 * Class aik naqsha ya design hoti hai jo batati hai ke us se banne wale
 * objects ke paas konsa data aur kaun se actions ho sakte hain.
 *
 * Real-life example:
 * Ghar ka naqsha class ki tarah hai. Aik naqshay se kai ghar ban sakte hain.
 * Har ghar alag object hai; uska rang ya address alag ho sakta hai.
 *
 * Basic syntax:
 * class ClassName
 * {
 *     // Fields/properties: data
 *     // Methods: actions
 * }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Dog class aik naqsha hai jo batata hai ke Dog object ke paas kya hoga.
class Dog
{
    // Name field har Dog object ka naam rakhta hai.
    public string Name;

    // Bark method Dog object ka action hai.
    public void Bark()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

class Program
{
    static void Main()
    {
        // Dog class se pehla object banaya.
        Dog dogOne = new Dog();
        dogOne.Name = "Max";

        // Dog class se doosra object banaya.
        Dog dogTwo = new Dog();
        dogTwo.Name = "Luna";

        // Dono objects ka Bark action chalaya.
        dogOne.Bark();
        dogTwo.Bark();
    }
}

/*
 * Expected output:
 * Max says: Woof!
 * Luna says: Woof!
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - class Dog Dog type ka naqsha define karta hai.
 * - public string Name; har Dog object ke liye naam store karta hai.
 * - public void Bark() aik method hai, yani object ka action.
 * - Console.WriteLine(...) screen par bark ka message dikhata hai.
 * - class Program application ka main code rakhta hai.
 * - static void Main() program ka starting point hai.
 * - Dog dogOne = new Dog(); Dog class ka naya object banata hai.
 * - dogOne.Name = "Max"; pehle object ka naam set karta hai.
 * - Dog dogTwo = new Dog(); doosra, alag Dog object banata hai.
 * - dogTwo.Name = "Luna"; doosre object ka naam set karta hai.
 * - dogOne.Bark(); pehle dog ke liye Bark method chalata hai.
 * - dogTwo.Bark(); doosre dog ke liye Bark method chalata hai.
 *
 * Yaad rakhein:
 * - Class = naqsha/type.
 * - Object = class se banayi hui asal instance.
 * - Aik class se zaroorat ke mutabiq kai objects ban sakte hain.
 * - Har object ka apna instance data hota hai.
 *
 * Practice exercises:
 *
 * Beginner 1: Cat naam ki class banayein. Us mein Name data aur Meow() method ho.
 * Beginner 2: Is example mein dogOne ka naam apne pasand ke naam se badlein.
 * Intermediate 1: Book class banayein jismein Title aur Author fields aur
 *                 ShowDetails() method ho; do book objects banayein.
 * Intermediate 2: Student class ke liye teen data items aur do actions suggest
 *                  karein; phir un mein se kam az kam aik method implement karein.
 * Real-world scenario: Library mein har kitab ko represent karne ke liye Book
 *                      class ka design banayein.
 *
 * Aap ki bari:
 * Cat class ka complete console program likhein. Do Cat objects banayein,
 * unke naam set karein, aur har aik se Meow() chalayein. Code bhejein;
 * main check karke ghaltiyan Roman English mein samjhaunga.
 */

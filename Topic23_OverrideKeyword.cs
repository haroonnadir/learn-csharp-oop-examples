using System;

/*
 * Topic 23: Override Keyword
 *
 * Technical definition (English):
 * The override keyword declares that a derived class provides a new
 * implementation of an inherited virtual, abstract, or already overridden
 * method or property.
 *
 * Roman English:
 * override keyword child class mein batata hai ke inherited virtual ya
 * abstract member ka naya implementation diya ja raha hai. Compiler check
 * karta hai ke base class mein waqai override hone wala member maujood ho.
 *
 * Real-life example:
 * Base class Animal ka default sound ho sakta hai. Dog class override laga
 * kar apni khaas awaz define karti hai.
 *
 * Syntax:
 * class Base
 * {
 *     public virtual void Action() { ... }
 * }
 * class Child : Base
 * {
 *     public override void Action() { ... }
 * }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Base class virtual method declare karti hai taa-ke derived classes override kar saken.
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Dog base method ko override karke apna sound deta hai.
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

class Program
{
    static void Main()
    {
        // Variable ka type Animal hai, magar asal object Dog hai.
        Animal animal = new Dog();

        // Runtime par override ki hui Dog implementation chalti hai.
        animal.MakeSound();
    }
}

/*
 * Expected output:
 * Dog says: Woof!
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - class Animal base class define karti hai.
 * - virtual MakeSound() default behavior deta hai aur override allow karta hai.
 * - class Dog : Animal, Dog ko Animal se inherit karwati hai.
 * - override MakeSound() batata hai ke Dog base ka virtual method replace kar raha hai.
 * - Console.WriteLine Dog ki specific awaz display karta hai.
 * - Main() program ka starting point hai.
 * - Animal animal = new Dog(); Animal reference ke andar Dog object rakhta hai.
 * - animal.MakeSound() runtime par asal Dog object ki override implementation chalata hai.
 *
 * Zaroori rules:
 * - Base member virtual, abstract, ya pehle se override hona chahiye.
 * - Derived member ka naam aur parameter list base method se match honi chahiye.
 * - override par return type aur parameter types bhi compatible hon.
 * - override base member ke access level ko zyada restrict nahi kar sakta.
 * - override keyword na ho to method override ke bajaye alag method/hiding ho sakta hai.
 *
 * Common ghalti:
 * Agar Animal mein MakeSound par virtual na likha ho, to
 * public override void MakeSound() compile-time error dega.
 * Override lagana compiler ko ghalat ya ghair-maujood base member pakarne mein madad deta hai.
 *
 * new aur override ka farq:
 * - override inherited virtual member ka runtime behavior replace karta hai.
 * - new base member ko hide karta hai; base-typed reference se call karne par
 *   aam tor par base implementation select hoti hai.
 * Dono keywords aik doosre ke badal nahi hain; new ko baad ke topic mein detail
 * se dekhenge.
 *
 * Practice exercises:
 *
 * Beginner 1: Animal mein virtual Move() add karein aur Dog mein override karein.
 * Beginner 2: Dog ke MakeSound message ko apne lafzon mein badlein.
 * Intermediate 1: Shape mein virtual Describe() aur Circle mein override likhein.
 * Intermediate 2: Base method se virtual hata kar override wala code try karein;
 *                  compiler error note karein, phir virtual wapas lagayein.
 * Real-world scenario: Notification mein virtual Send() aur EmailNotification
 *                      mein override laga kar email ka khaas message dikhayein.
 *
 * Aap ki bari:
 * Vehicle class mein virtual Start() banayein. ElectricCar : Vehicle mein
 * override Start() karke electric motor ka message dikhayein. Vehicle reference
 * mein ElectricCar object bana kar Start() call karein. Code bhejein; main check karunga.
 */

using System;

/*
 * Topic 18: Multiple Inheritance using Interfaces
 *
 * Technical definition (English):
 * C# does not allow a class to inherit from multiple classes. A class can,
 * however, implement multiple interfaces and provide the behavior each
 * interface requires.
 *
 * Roman English:
 * C# mein aik class aik se zyada classes se inherit nahi kar sakti. Lekin aik
 * class multiple interfaces implement kar sakti hai aur unke required methods
 * khud provide kar sakti hai.
 *
 * Real-life example:
 * SmartPhone aik Phone bhi hai aur aik Camera bhi: woh call kar sakta hai aur
 * photo le sakta hai. C# mein yeh capabilities interfaces se represent kar
 * sakte hain.
 *
 * Syntax:
 * interface IFirst { void FirstAction(); }
 * interface ISecond { void SecondAction(); }
 * class Example : IFirst, ISecond { ... }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Interface batata hai ke implement karne wali class ko kya action dena hai.
interface ICanCall
{
    void MakeCall(string number);
}

// Doosra interface aik aur required capability batata hai.
interface ICanTakePhotos
{
    void TakePhoto();
}

// SmartPhone do interfaces implement karta hai, yani dono capabilities deta hai.
class SmartPhone : ICanCall, ICanTakePhotos
{
    public void MakeCall(string number)
    {
        Console.WriteLine($"Calling {number}...");
    }

    public void TakePhoto()
    {
        Console.WriteLine("Photo taken.");
    }
}

class Program
{
    static void Main()
    {
        SmartPhone phone = new SmartPhone();

        // SmartPhone class dono interfaces ke methods implement karti hai.
        phone.MakeCall("555-0100");
        phone.TakePhoto();
    }
}

/*
 * Expected output:
 * Calling 555-0100...
 * Photo taken.
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ke liye hai.
 * - interface ICanCall aik capability ka contract define karta hai.
 * - void MakeCall(string number); method signature batati hai ke call action
 *   ko string number chahiye. Interface mein is method ka body nahi diya.
 * - interface ICanTakePhotos doosri capability ka contract hai.
 * - void TakePhoto(); photo lene wale method ka signature hai.
 * - class SmartPhone : ICanCall, ICanTakePhotos dono interfaces implement karti hai.
 * - MakeCall(...) ICanCall ke required method ka implementation hai.
 * - TakePhoto() ICanTakePhotos ke required method ka implementation hai.
 * - Main() program ka starting point hai.
 * - new SmartPhone() aik phone object banata hai.
 * - phone.MakeCall(...) call ka message print karta hai.
 * - phone.TakePhoto() photo ka message print karta hai.
 *
 * Ahm farq:
 * - Multiple class inheritance: C# mein allowed nahi; class sirf aik class se
 *   directly inherit kar sakti hai.
 * - Multiple interface implementation: allowed hai; class comma-separated
 *   kai interfaces implement kar sakti hai.
 * - Interface capabilities/contracts define karta hai; implementing class
 *   un operations ka code provide karti hai.
 *
 * Faida:
 * Mukhtalif, ghair-mutaliq classes aik common capability ka contract follow
 * kar sakti hain, bina aik hi class hierarchy mein zabardasti fit hue.
 *
 * Ehtiyat:
 * Interface implement karne wali class ko uske required members provide karne
 * hote hain. Interface ka design chhota aur aik wazeh responsibility wala rakhein.
 *
 * Practice exercises:
 *
 * Beginner 1: ICanPlayMusic interface banayein jismein PlayMusic() ho.
 * Beginner 2: SmartPhone mein PlayMusic() implement karke call karein.
 * Intermediate 1: IPrintable aur ISavable interfaces banayein; Report class
 *                  dono implement kare.
 * Intermediate 2: Ehtiyat se samjhayen ke C# multiple base classes ki bajaye
 *                  multiple interfaces kyun support karta hai.
 * Real-world scenario: University project mein ICanTeach, ICanStudy aur
 *                      ICanManage interfaces alag capabilities define karein.
 *
 * Aap ki bari:
 * ICanFly aur ICanSwim interfaces banayein. Duck class dono implement kare,
 * Fly() aur Swim() methods provide kare. Duck object bana kar dono methods
 * call karein. Code bhejein; main check karke Roman English mein samjhaunga.
 */

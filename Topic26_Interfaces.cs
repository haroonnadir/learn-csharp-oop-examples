using System;

/*
 * Topic 26: Interfaces
 *
 * Technical definition (English):
 * An interface defines a contract of members that a non-abstract implementing
 * type must provide. A class can implement more than one interface.
 *
 * Roman English:
 * Interface aik contract hota hai jo batata hai ke usay implement karne wali
 * class ko kaun se members dene honge. Class multiple interfaces implement
 * kar sakti hai.
 *
 * Real-life example:
 * Mukhtalif devices print kar sakte hain. IPrintable interface yeh contract
 * batata hai ke Print() method hona chahiye, magar har device apna print tareeqa
 * implement karta hai.
 *
 * Syntax:
 * interface IExample
 * {
 *     void DoWork();
 * }
 * class Example : IExample
 * {
 *     public void DoWork() { ... }
 * }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Interface batata hai ke implementer ko Print method dena hoga.
interface IPrintable
{
    void Print();
}

// Doosra interface aik alag capability ka contract hai.
interface ISavable
{
    void Save();
}

// Report dono interfaces implement karke dono methods provide karti hai.
class Report : IPrintable, ISavable
{
    public string Title { get; set; }

    public Report(string title)
    {
        Title = title;
    }

    public void Print()
    {
        Console.WriteLine($"Printing report: {Title}");
    }

    public void Save()
    {
        Console.WriteLine($"Saving report: {Title}");
    }
}

class Program
{
    static void Main()
    {
        Report report = new Report("Monthly Results");

        // Concrete class ke zariye interface methods call karte hain.
        report.Print();
        report.Save();

        // Interface type se bhi implementing object use ho sakta hai.
        IPrintable printable = report;
        printable.Print();
    }
}

/*
 * Expected output:
 * Printing report: Monthly Results
 * Saving report: Monthly Results
 * Printing report: Monthly Results
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - interface IPrintable contract define karta hai.
 * - void Print(); method signature hai; is simple example mein body nahi.
 * - interface ISavable doosra contract define karta hai.
 * - void Save(); save capability ka required member hai.
 * - class Report : IPrintable, ISavable dono contracts implement karti hai.
 * - Title property report ka data rakhti hai.
 * - Report(string title) constructor Title initialize karta hai.
 * - public void Print() IPrintable ka implementation hai.
 * - public void Save() ISavable ka implementation hai.
 * - Main() program ka starting point hai.
 * - new Report(...) report object banata hai.
 * - report.Print() aur report.Save() concrete object par methods chalate hain.
 * - IPrintable printable = report; Report object ko interface reference mein rakhta hai.
 * - printable.Print() interface contract ke zariye wahi implementation chalata hai.
 *
 * Interface aur abstract class ka mukhtasar farq:
 * - Interface capabilities/contracts define karne ke liye hai; class multiple
 *   interfaces implement kar sakti hai.
 * - Abstract class common state, constructors aur implemented behavior rakh sakti
 *   hai; class sirf aik base class se inherit karti hai.
 * - Modern C# interfaces mein default implementations aur static members bhi
 *   ho sakte hain. Is beginner lesson mein common contract pattern dikhaya hai.
 *
 * Practice exercises:
 *
 * Beginner 1: IPrintable implement karne wali Invoice class banayein.
 * Beginner 2: Report ka title badal kar output dobara dekhein.
 * Intermediate 1: IPlayable aur IRecordable interfaces banayein; MediaPlayer
 *                 class dono implement kare.
 * Intermediate 2: IPrintable reference mein Report object rakhein aur samjhayen
 *                  ke caller ko Report ki tamam details kyun jaan'na zaroori nahi.
 * Real-world scenario: University project mein ICanTeach, ICanStudy aur
 *                      ICanManage interfaces alag capabilities dikhayein.
 *
 * Aap ki bari:
 * ILogger interface mein Log(string message) method declare karein. ConsoleLogger
 * class usay implement kare. Interface reference se logger ko call karke message
 * print karein. Code bhejein; main check karke Roman English mein samjhaunga.
 */

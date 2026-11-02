using System;

/*
 * Topic 25: Abstract Methods
 *
 * Technical definition (English):
 * An abstract method is a method declared without a body in an abstract class.
 * A non-abstract derived class must override and implement it.
 *
 * Roman English:
 * Abstract method abstract class mein declare hota hai lekin uska method body
 * nahi hota. Concrete child class ko override karke uska kaam likhna hota hai.
 *
 * Real-life example:
 * Har employee ki pay calculate hoti hai, lekin hourly aur salaried employee
 * ki calculation mukhtalif hoti hai. Base class rule mangti hai; child apna
 * formula deta hai.
 *
 * Syntax:
 * abstract class BaseClass
 * {
 *     public abstract ReturnType MethodName(parameters);
 * }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Abstract class abstract method aur common implemented method dono rakh sakti hai.
abstract class Employee
{
    public string Name { get; }

    protected Employee(string name)
    {
        Name = name;
    }

    // Is method ka body nahi; concrete child class ko implementation deni hogi.
    public abstract decimal CalculatePay();

    // Yeh ready method tamam Employee subclasses ke liye common hai.
    public void ShowPay()
    {
        Console.WriteLine($"{Name}'s pay: {CalculatePay():C}");
    }
}

// SalariedEmployee abstract method ko monthly salary se implement karta hai.
class SalariedEmployee : Employee
{
    private decimal monthlySalary;

    public SalariedEmployee(string name, decimal salary) : base(name)
    {
        monthlySalary = salary;
    }

    public override decimal CalculatePay()
    {
        return monthlySalary;
    }
}

// HourlyEmployee usi abstract method ko hours aur rate se implement karta hai.
class HourlyEmployee : Employee
{
    private decimal hourlyRate;
    private int hoursWorked;

    public HourlyEmployee(string name, decimal rate, int hours) : base(name)
    {
        hourlyRate = rate;
        hoursWorked = hours;
    }

    public override decimal CalculatePay()
    {
        return hourlyRate * hoursWorked;
    }
}

class Program
{
    static void Main()
    {
        Employee salaried = new SalariedEmployee("Amina", 3000m);
        Employee hourly = new HourlyEmployee("Bilal", 20m, 80);

        salaried.ShowPay();
        hourly.ShowPay();
    }
}

/*
 * Expected output (currency symbol/format current culture ke mutabiq ho sakti hai):
 * Amina's pay: $3,000.00
 * Bilal's pay: $1,600.00
 *
 * Line-by-line samajh:
 * - using System; Console aur decimal currency formatting ke liye hai.
 * - abstract class Employee ka direct object nahi ban sakta.
 * - Name property employee ka naam rakhti hai.
 * - protected Employee(...) constructor ko class aur derived classes use kar sakti hain.
 * - abstract decimal CalculatePay(); sirf contract/signature hai, body nahi.
 * - ShowPay() common method hai jo CalculatePay() ka result format karke dikhata hai.
 * - class SalariedEmployee : Employee base class se inherit karti hai.
 * - monthlySalary private field salary store karta hai.
 * - SalariedEmployee constructor : base(name) se Employee constructor call karta hai.
 * - override CalculatePay() monthly salary return karta hai.
 * - class HourlyEmployee : Employee doosri concrete derived class hai.
 * - hourlyRate aur hoursWorked private fields calculation ka data rakhte hain.
 * - HourlyEmployee constructor pehle base Name set karta, phir apne fields set karta hai.
 * - HourlyEmployee ka override rate ko hours se multiply karke pay deta hai.
 * - Main() do Employee references mein mukhtalif concrete objects rakhta hai.
 * - ShowPay() dono par call hota hai; har object ka apna CalculatePay chalta hai.
 * - 3000m aur 20m decimal literals hain; m suffix decimal type dikhata hai.
 * - :C currency format use karta hai; currency symbol machine ki culture setting
 *   par depend kar sakta hai.
 *
 * Abstract method aur abstract class:
 * - Abstract method body ke baghair declaration hota hai aur override mangta hai.
 * - Abstract method sirf abstract class (ya record) mein declare ho sakta hai.
 * - Abstract class mein abstract methods ke ilawa body wale normal methods bhi ho sakte hain.
 * - Concrete derived class ko tamam inherited abstract members implement karne hote hain.
 *
 * Practice exercises:
 *
 * Beginner 1: Employee mein abstract string GetRole() method add karein aur
 *             SalariedEmployee implement kare.
 * Beginner 2: HourlyEmployee ke hoursWorked ko badal kar pay ka output dekhein.
 * Intermediate 1: Shape abstract class mein abstract double CalculateArea()
 *                  banayein; Circle aur Rectangle implement karein.
 * Intermediate 2: Aik abstract method ko override na karne wali non-abstract
 *                  child class compile kyun nahi karti? Is rule ko samjhayen.
 * Real-world scenario: Report abstract class mein abstract GenerateContent()
 *                      rakhein; PdfReport aur TextReport alag output dein.
 *
 * Aap ki bari:
 * abstract class Shape mein abstract double CalculateArea() aur common
 * ShowArea() method banayein. Circle aur Rectangle is method ko override karein.
 * Dono shapes bana kar area display karein. Code bhejein; main check karunga.
 */

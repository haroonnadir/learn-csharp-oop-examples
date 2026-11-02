using System;

/*
 * Topic 24: Abstract Classes
 *
 * Technical definition (English):
 * An abstract class is a class that cannot be instantiated directly. It can
 * provide shared state and implemented members, and can require derived
 * classes to provide abstract members.
 *
 * Roman English:
 * Abstract class aisi class hoti hai jis ka direct object nahi banaya ja sakta.
 * Yeh common properties aur ready methods de sakti hai, aur derived classes
 * se kuch methods implement karne ka taqaza bhi kar sakti hai.
 *
 * Real-life example:
 * "Shape" aik general idea hai, magar uska exact area formula shape ki qisam
 * par depend karta hai. Circle aur Rectangle apna area calculate karte hain.
 *
 * Syntax:
 * abstract class BaseClass
 * {
 *     public abstract void RequiredAction();
 *     public void SharedAction() { ... }
 * }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Abstract class ka direct object nahi ban sakta.
abstract class Shape
{
    // Abstract property har concrete derived shape se area mangti hai.
    public abstract double Area { get; }

    // Ready implementation tamam shapes ke liye common hai.
    public void ShowArea()
    {
        Console.WriteLine($"Area: {Area}");
    }
}

// Circle class required Area property implement karti hai.
class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area
    {
        get { return Math.PI * Radius * Radius; }
    }
}

// Rectangle bhi apne tareeqe se required Area property implement karta hai.
class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area
    {
        get { return Width * Height; }
    }
}

class Program
{
    static void Main()
    {
        // Abstract base type ke references concrete objects ko refer karte hain.
        Shape circle = new Circle(2);
        Shape rectangle = new Rectangle(3, 4);

        circle.ShowArea();
        rectangle.ShowArea();

        // Yeh allowed nahi: abstract class ka direct object nahi banta.
        // Shape shape = new Shape();
    }
}

/*
 * Expected output (pi ki rounding runtime formatting ke mutabiq):
 * Area: 12.566370614359172
 * Area: 12
 *
 * Line-by-line samajh:
 * - using System; Console aur Math types use karne deta hai.
 * - abstract class Shape ka direct object nahi ban sakta.
 * - abstract double Area { get; } property ka body nahi; child ko value deni hai.
 * - ShowArea() implemented/common method hai; yeh Area property read karke print karta hai.
 * - class Circle : Shape Circle ko abstract Shape se derive karti hai.
 * - Radius property circle ka apna data rakhti hai.
 * - Circle(double radius) constructor Radius initialize karta hai.
 * - override Area ka getter pi * radius * radius calculate karta hai.
 * - class Rectangle : Shape doosri concrete derived class hai.
 * - Width aur Height rectangle ka data hain.
 * - Rectangle constructor dono dimensions initialize karta hai.
 * - override Area width aur height multiply karke area deta hai.
 * - Main() program ka starting point hai.
 * - Shape references Circle aur Rectangle objects ko rakhte hain.
 * - Dono ShowArea() calls common method chalati hain; Area ki value asal object
 *   ki override property se milti hai.
 * - Commented Shape object line compile nahi hogi kyun ke Shape abstract hai.
 *
 * Abstract class mein:
 * - abstract members body nahi rakhte; concrete child classes unhein implement karti hain.
 * - non-abstract members ready implementation rakh sakte hain.
 * - fields, properties, constructors aur methods ho sakte hain.
 * - abstract class se direct object nahi banta.
 *
 * Abstract class vs interface ki poori comparison baad ke topic mein hogi.
 *
 * Practice exercises:
 *
 * Beginner 1: Shape mein abstract string Name property add karein aur Circle implement kare.
 * Beginner 2: Rectangle ke dimensions badal kar naya area calculate karein.
 * Intermediate 1: Employee abstract class mein abstract CalculatePay() aur
 *                 implemented ShowRole() method banayein.
 * Intermediate 2: Triangle : Shape banayein aur Area ko base aur height se
 *                  calculate karein (area = base * height / 2).
 * Real-world scenario: PaymentMethod abstract base class mein shared currency
 *                      property aur abstract ProcessPayment() rakhein; Card aur
 *                      Cash implementations banayein.
 *
 * Aap ki bari:
 * abstract class Employee banayein jismein Name property, abstract decimal
 * CalculatePay(), aur ShowPay() method ho. SalariedEmployee derived class mein
 * monthly salary se CalculatePay implement karein. Object bana kar pay display
 * karein. Code bhejein; main check karke samjhaunga.
 */

using System;

/*
 * Topic 14: Inheritance
 *
 * Technical definition (English):
 * Inheritance is a feature that lets a new class (derived class) acquire
 * accessible members and behavior from an existing class (base class), and
 * add its own members.
 *
 * Roman English:
 * Inheritance mein nayi class, purani class se accessible data aur methods
 * le sakti hai. Nayi class ko child/derived class aur asal class ko
 * parent/base class kehte hain. Child class apne extra members bhi bana sakti hai.
 *
 * Why we use it:
 * Common behavior ko aik base class mein rakh kar related classes mein reuse
 * karne ke liye. Is se duplicate code kam ho sakta hai.
 *
 * Real-life example:
 * Student aur Teacher dono Person hain. Dono ka naam common ho sakta hai,
 * lekin Student ka Study action aur Teacher ka Teach action alag ho sakta hai.
 *
 * Basic syntax:
 * class ChildClass : ParentClass
 * {
 *     // Child ke apne members
 * }
 *
 * C# classes mein aik class se hi directly inherit kiya ja sakta hai.
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Person base/parent class hai, jo common Name data rakhti hai.
class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public void Introduce()
    {
        Console.WriteLine($"My name is {Name}.");
    }
}

// Student derived/child class hai; Student "is a" Person.
class Student : Person
{
    public int Grade { get; set; }

    public Student(string name, int grade) : base(name)
    {
        Grade = grade;
    }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying in grade {Grade}.");
    }
}

class Program
{
    static void Main()
    {
        // Student object apna Grade aur inherited Person ka Name rakhta hai.
        Student student = new Student("Amina", 8);

        // Inherited base-class method call hota hai.
        student.Introduce();

        // Student class ka apna method call hota hai.
        student.Study();
    }
}

/*
 * Expected output:
 * My name is Amina.
 * Amina is studying in grade 8.
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - class Person common parent class define karti hai.
 * - Name property har person ka naam rakhti hai.
 * - Person(string name) constructor Name ko initialize karta hai.
 * - Introduce() common behavior hai jo Person ka naam print karta hai.
 * - class Student : Person batata hai ke Student, Person se inherit karti hai.
 * - Grade Student ka apna member hai; yeh Person mein define nahi.
 * - Student(string name, int grade) child class ka constructor hai.
 * - : base(name) parent Person constructor ko name de kar call karta hai.
 * - Grade = grade; Student ki apni property initialize karta hai.
 * - Study() Student class ka apna behavior hai.
 * - Main() se program execution shuru hoti hai.
 * - new Student("Amina", 8) Student object banata aur constructor chalata hai.
 * - student.Introduce() inherited Person method chalata hai.
 * - student.Study() Student ka apna method chalata hai.
 *
 * Inheritance kab munasib hoti hai?
 * Jab child waqai parent ki qisam ho, yani "Student is a Person".
 * Sirf code reuse ke liye ghalat parent-child relation banana munasib nahi.
 *
 * Yaad rahe:
 * - Child ko base class ke public aur protected members milte hain.
 * - Base class ke private members child mein directly accessible nahi hote.
 * - C# class aik hi class se directly inherit karti hai, lekin interfaces
 *   multiple implement kar sakti hai; interfaces baad mein parhenge.
 * - : base(...) parent constructor ko call karta hai.
 *
 * Practice exercises:
 *
 * Beginner 1: Person mein Age property add karein aur Student ke liye set karein.
 * Beginner 2: Teacher : Person class banayein aur Teach() method add karein.
 * Intermediate 1: Vehicle base class mein Brand aur ShowBrand() rakhein.
 *                 Car : Vehicle banayein aur apni Model property add karein.
 * Intermediate 2: Samjhayen ke "Car is a Vehicle" inheritance ke liye munasib
 *                  kyun hai, jab ke "Car has an Engine" aam tor par composition hai.
 * Real-world scenario: University system mein Person common base class ho,
 *                      aur Student aur Teacher us se common name lein.
 *
 * Aap ki bari:
 * Vehicle base class likhein jismein Brand property aur ShowBrand() method ho.
 * Car : Vehicle banayein, Model property add karein, aur Main mein Car object
 * bana kar inherited aur apne members use karein. Code bhejein; main check karunga.
 */

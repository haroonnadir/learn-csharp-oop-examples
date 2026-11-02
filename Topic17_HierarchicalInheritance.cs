using System;

/*
 * Topic 17: Hierarchical Inheritance
 *
 * Technical definition (English):
 * Hierarchical inheritance is a class structure in which two or more derived
 * classes inherit from the same base class.
 *
 * Roman English:
 * Hierarchical inheritance mein do ya zyada child classes aik hi parent/base
 * class se inherit karti hain. Har child ko base ke accessible members milte
 * hain, aur har child apne khaas members bhi rakh sakti hai.
 *
 * Real-life example:
 * Student aur Teacher dono Person hain. Dono ka naam aur introduce karne ka
 * behavior common hai, lekin Student study karta hai aur Teacher teach karta hai.
 *
 * Syntax:
 * class A { }
 * class B : A { }
 * class C : A { }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Person common base class hai.
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

// Student pehli child class hai jo Person se inherit karti hai.
class Student : Person
{
    public int Grade { get; set; }

    public Student(string name, int grade) : base(name)
    {
        Grade = grade;
    }

    public void Study()
    {
        Console.WriteLine($"{Name} studies in grade {Grade}.");
    }
}

// Teacher doosri child class hai jo usi Person class se inherit karti hai.
class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, string subject) : base(name)
    {
        Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} teaches {Subject}.");
    }
}

class Program
{
    static void Main()
    {
        // Dono child objects apni class aur Person ke common members use karte hain.
        Student student = new Student("Amina", 8);
        Teacher teacher = new Teacher("Mr. Khan", "Mathematics");

        student.Introduce();
        student.Study();

        teacher.Introduce();
        teacher.Teach();
    }
}

/*
 * Expected output:
 * My name is Amina.
 * Amina studies in grade 8.
 * My name is Mr. Khan.
 * Mr. Khan teaches Mathematics.
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - class Person common parent class define karti hai.
 * - Name property dono qisam ke persons ke liye common data hai.
 * - Person(string name) constructor Name initialize karta hai.
 * - Introduce() common method hai jo naam display karta hai.
 * - class Student : Person Student ko Person se inherit karwati hai.
 * - Grade Student ka khaas data hai.
 * - Student constructor : base(name) se Person constructor ko call karta hai.
 * - Study() Student ka apna action hai.
 * - class Teacher : Person Teacher ko usi base class se inherit karwati hai.
 * - Subject Teacher ka khaas data hai.
 * - Teacher constructor : base(name) se Person ka Name set karta hai.
 * - Teach() Teacher ka apna action hai.
 * - Main() program ka starting point hai.
 * - Student aur Teacher objects apne child-specific data ke saath bante hain.
 * - Dono Introduce() inherited method use karte hain.
 * - Student Study() aur Teacher Teach() apne alag methods use karte hain.
 *
 * Faida:
 * Common data/behavior Person mein aik martaba likha gaya. Student aur Teacher
 * dono usay reuse karte hain, magar apne khaas behavior alag rakhte hain.
 *
 * Ehtiyat:
 * Base class mein sirf woh members rakhein jo tamam child classes ke liye waqai
 * common hon. Har cheez ko aik hi parent mein rakhna class ko be-wajah bara kar sakta hai.
 *
 * Practice exercises:
 *
 * Beginner 1: Person mein Age property add karein; Student aur Teacher dono ko value dein.
 * Beginner 2: Teacher mein ShowSubject() method add karein.
 * Intermediate 1: Vehicle base class se Car aur Motorcycle derive karein.
 *                 Common Brand rakhein aur har child ka apna action banayein.
 * Intermediate 2: Aik aur Person child class, Admin, banayein. Us mein Role
 *                  property aur ManageUsers() method add karein.
 * Real-world scenario: University mein Person base class se Student, Teacher,
 *                      Admin aur Principal classes banayein.
 *
 * Aap ki bari:
 * Person base class banayein aur Student, Teacher, Admin teen child classes
 * us se inherit karwayein. Har child ka aik apna method ho. Teeno objects bana
 * kar common Introduce() aur apna-apna method call karein. Code bhejein;
 * main check karke Roman English mein samjhaunga.
 */

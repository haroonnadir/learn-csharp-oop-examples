using System;

/*
 * Topic 9: Default Constructor
 *
 * Technical definition (English):
 * A parameterless constructor is a constructor that takes no arguments.
 * If a class declares no instance constructor, C# supplies a parameterless
 * default constructor. If the class declares another constructor, C# does
 * not automatically supply that constructor.
 *
 * Roman English:
 * Parameterless constructor woh constructor hai jo koi argument nahi leta.
 * Agar class mein koi instance constructor likha na ho, C# khud aik khaali
 * default constructor deta hai. Lekin apna constructor likhne ke baad C#
 * automatic default constructor nahi deta.
 *
 * Real-life example:
 * Naya student record bina details ke banaya ja sakta hai, aur baad mein
 * uski Name aur Grade values set ki ja sakti hain.
 *
 * Syntax:
 * public ClassName()
 * {
 *     // Zaroorat par initial values
 * }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Is class mein koi constructor declare nahi kiya, is liye compiler
// parameterless default constructor provide karta hai.
class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}

// Is class mein apna parameterless constructor explicitly likha hai.
class Course
{
    public string Title { get; set; }

    public Course()
    {
        Title = "Not assigned";
    }
}

class Program
{
    static void Main()
    {
        // Student ke liye compiler ka diya hua default constructor chalta hai.
        Student student = new Student();
        student.Name = "Amina";
        student.Grade = 8;

        // Course ke liye hamara likha hua parameterless constructor chalta hai.
        Course course = new Course();

        Console.WriteLine($"{student.Name} is in grade {student.Grade}.");
        Console.WriteLine($"Course: {course.Title}");
    }
}

/*
 * Expected output:
 * Amina is in grade 8.
 * Course: Not assigned
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - class Student mein constructor declare nahi kiya.
 * - Is liye C# Student ke liye parameterless default constructor deta hai.
 * - Name aur Grade Student object ki properties hain.
 * - class Course aik doosri class hai.
 * - Title Course object ki property hai.
 * - public Course() khud likha hua parameterless constructor hai.
 * - Title = "Not assigned"; nayi Course ka starting title set karta hai.
 * - static void Main() se program execution shuru hoti hai.
 * - new Student() compiler ke supplied default constructor ko chalata hai.
 * - Agli do assignments student ki properties ko values deti hain.
 * - new Course() hamara Course constructor chalata hai.
 * - Console.WriteLine dono objects ki property values display karta hai.
 *
 * Ahm nuqta:
 * Agar aap Student class mein parameterized constructor add kar dein, misal:
 * public Student(string name) { Name = name; }
 * to new Student() automatic taur par available nahi rahega. Agar parameterless
 * constructor bhi chahiye ho to usay khud declare karein.
 *
 * Practice exercises:
 *
 * Beginner 1: Book class banayein jismein default constructor Title ko
 *             "Untitled" set kare.
 * Beginner 2: new Book() se object bana kar uska Title display karein.
 * Intermediate 1: Product class mein parameterless constructor likhein jo
 *                 Price ko 0 set kare.
 * Intermediate 2: Aik class mein parameterized constructor add karne ke baad
 *                  new ClassName() kyun kaam nahi karega? Chhota example likhein.
 * Real-world scenario: Naya shopping-cart object default taur par empty ho;
 *                      constructor uski initial status "Empty" set kare.
 *
 * Aap ki bari:
 * Product class likhein jismein Name aur Price properties hon. Parameterless
 * constructor Name ko "Unknown" aur Price ko 0 set kare. Object bana kar
 * dono values print karein. Code bhejein; main check karke samjhaunga.
 */

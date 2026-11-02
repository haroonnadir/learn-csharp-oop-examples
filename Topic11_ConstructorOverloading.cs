using System;

/*
 * Topic 11: Constructor Overloading
 *
 * Technical definition (English):
 * Constructor overloading means defining multiple constructors in the same
 * class with different parameter lists. The compiler chooses a constructor
 * based on the arguments supplied when an object is created.
 *
 * Roman English:
 * Constructor overloading ka matlab hai aik class mein multiple constructors
 * banana, jin ke parameters ki tadaad ya types mukhtalif hon. Object banate
 * waqt diye gaye arguments ke mutabiq C# sahi constructor choose karta hai.
 *
 * Real-life example:
 * Student record kabhi sirf naam se, kabhi naam aur grade se, aur kabhi bina
 * details ke banaya ja sakta hai. Mukhtalif constructors yeh options dete hain.
 *
 * Basic syntax:
 * public ClassName() { ... }
 * public ClassName(string name) { ... }
 * public ClassName(string name, int grade) { ... }
 *
 * Constructors ke parameter lists alag hone chahiye. Sirf return type ya
 * parameter names badalne se constructor overload nahi hota.
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }

    // Bina arguments ke object banane ka option.
    public Student() : this("Unknown", 0)
    {
    }

    // Sirf naam de kar object banane ka option.
    public Student(string name) : this(name, 0)
    {
    }

    // Naam aur grade dono de kar object banane ka option.
    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public void ShowInformation()
    {
        Console.WriteLine($"{Name} is in grade {Grade}.");
    }
}

class Program
{
    static void Main()
    {
        // Parameterless constructor "Unknown" aur 0 values use karta hai.
        Student firstStudent = new Student();

        // One-parameter constructor naam leta hai, grade 0 rehta hai.
        Student secondStudent = new Student("Amina");

        // Two-parameter constructor naam aur grade dono leta hai.
        Student thirdStudent = new Student("Bilal", 9);

        firstStudent.ShowInformation();
        secondStudent.ShowInformation();
        thirdStudent.ShowInformation();
    }
}

/*
 * Expected output:
 * Unknown is in grade 0.
 * Amina is in grade 0.
 * Bilal is in grade 9.
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - class Student teen constructor options aur student data define karti hai.
 * - Name aur Grade properties har object ki values rakhti hain.
 * - public Student() parameterless constructor hai; koi argument nahi leta.
 * - : this("Unknown", 0) isi class ke do-parameter constructor ko call karta hai.
 *   Isay constructor chaining kehte hain.
 * - public Student(string name) aik string argument leta hai.
 * - : this(name, 0) naam ko aage bhejta hai aur grade ke liye 0 use karta hai.
 * - public Student(string name, int grade) do parameters leta hai.
 * - Name = name aur Grade = grade properties mein initial values set karte hain.
 * - ShowInformation() object ka naam aur grade display karta hai.
 * - Main() se program execution shuru hoti hai.
 * - new Student() zero-parameter constructor ko select karta hai.
 * - new Student("Amina") aik string parameter wala constructor select karta hai.
 * - new Student("Bilal", 9) string aur int wala constructor select karta hai.
 * - Aakhri teen calls har object ki information dikhati hain.
 *
 * Ahm nuqta:
 * Constructor overload ka faisla parameter count aur types se hota hai.
 * : this(...) istemal karke aik constructor doosre constructor ko call kar
 * sakta hai. Is se initialization logic duplicate karne ki zaroorat kam hoti hai.
 *
 * Practice exercises:
 *
 * Beginner 1: Book class mein Title ke liye parameterless aur one-parameter
 *             constructors banayein.
 * Beginner 2: new Book() aur new Book("C# Basics") se objects banayein.
 * Intermediate 1: Product class mein constructor overloads banayein: Name;
 *                 Name + Price; Name + Price + Category.
 * Intermediate 2: Rectangle class mein parameterless constructor aur width/
 *                  height lene wala constructor banayein. Dono se area nikalein.
 * Real-world scenario: BankAccount ko sirf owner ke naam se ya owner aur
 *                      starting balance ke saath banane ke options dein.
 *
 * Aap ki bari:
 * Book class likhein jismein parameterless constructor Title ko "Untitled"
 * set kare, one-parameter constructor title le, aur two-parameter constructor
 * title aur author le. : this(...) se initialization duplicate na karein.
 * Teen objects bana kar details dikhayein aur code bhejein; main check karunga.
 */

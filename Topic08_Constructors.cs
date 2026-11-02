using System;

/*
 * Topic 8: Constructors
 *
 * Technical definition (English):
 * A constructor is a special class member that runs when an object is created.
 * It is commonly used to initialize the new object's data.
 *
 * Roman English:
 * Constructor class ka khaas member hota hai jo naya object bante hi chalta
 * hai. Aksar isay object ke data ko shuru ki values dene ke liye use karte hain.
 *
 * Real-life example:
 * Naya student register karte waqt uska naam aur grade foran record karna.
 * Constructor object banate waqt yeh initial information set kar sakta hai.
 *
 * Basic syntax:
 * class ClassName
 * {
 *     public ClassName()
 *     {
 *         // Object ki initial setup
 *     }
 * }
 *
 * Constructor ka naam class ke naam jaisa hota hai aur iska return type nahi hota.
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

class Student
{
    // Property student ka naam rakhti hai.
    public string Name { get; set; }

    // Property student ka grade rakhti hai.
    public int Grade { get; set; }

    // Constructor object banne par initial values set karta hai.
    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    // Student ki maloomat display karta hai.
    public void ShowInformation()
    {
        Console.WriteLine($"{Name} is in grade {Grade}.");
    }
}

class Program
{
    static void Main()
    {
        // new Student(...) object banata hai aur constructor chalata hai.
        Student firstStudent = new Student("Amina", 8);
        Student secondStudent = new Student("Bilal", 9);

        // Dono students ki initial values dikhata hai.
        firstStudent.ShowInformation();
        secondStudent.ShowInformation();
    }
}

/*
 * Expected output:
 * Amina is in grade 8.
 * Bilal is in grade 9.
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - class Student Student object ka naqsha hai.
 * - Name aur Grade properties student ka data rakhti hain.
 * - public Student(string name, int grade) constructor hai:
 *   iska naam class ke naam jaisa hai aur iske aage return type nahi.
 * - name aur grade constructor ke parameters hain.
 * - Name = name; parameter ki value object ki Name property mein rakhta hai.
 * - Grade = grade; parameter ki value object ki Grade property mein rakhta hai.
 * - ShowInformation() student ki values display karta hai.
 * - static void Main() program ka starting point hai.
 * - new Student("Amina", 8) aik object banata hai aur constructor ko values deta hai.
 * - secondStudent ke liye bhi naya object banta hai, magar uski values alag hain.
 * - Aakhri do calls har object ki apni information dikhati hain.
 *
 * Ahm baat:
 * Agar class mein koi constructor declare na kiya ho, C# aam tor par
 * parameterless default constructor deta hai. Lekin jab aap khud koi
 * constructor likh dete hain, compiler woh automatic parameterless
 * constructor nahi deta. Default aur parameterized constructors aglay
 * topics mein alag se parhenge.
 *
 * Practice exercises:
 *
 * Beginner 1: Book class mein Title property aur title set karne wala constructor banayein.
 * Beginner 2: Is example mein aik teesra Student object constructor se banayein.
 * Intermediate 1: Product class mein Name aur Price properties hon; constructor
 *                  dono ki initial values le aur method se print kare.
 * Intermediate 2: Constructor mein parameter names aur properties ke naam same
 *                  kyun nahin rakhe, apne alfaaz mein samjhayen.
 * Real-world scenario: Bank account object bante waqt account holder ka naam
 *                      aur initial balance set karein.
 *
 * Aap ki bari:
 * Book class likhein jismein Title aur Author properties, dono ko initialize
 * karne wala constructor, aur ShowDetails() method ho. Main mein aik Book object
 * banayein aur uski details print karein. Code bhejein; main check karke samjhaunga.
 */

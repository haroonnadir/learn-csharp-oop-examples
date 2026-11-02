using System;

/*
 * Topic 10: Parameterized Constructor
 *
 * Technical definition (English):
 * A parameterized constructor is a constructor that receives one or more
 * parameters so a new object can be initialized with supplied values.
 *
 * Roman English:
 * Parameterized constructor woh constructor hai jo aik ya zyada parameters
 * leta hai. Object banate waqt di hui values se us object ka data initialize
 * kiya jata hai.
 *
 * Real-life example:
 * Naya student register karte hi uska naam aur grade dena, taa-ke student
 * object shuru se apni zaroori information rakhe.
 *
 * Syntax:
 * public ClassName(string value)
 * {
 *     Property = value;
 * }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

class Student
{
    // Properties student ka naam aur grade rakhti hain.
    public string Name { get; set; }
    public int Grade { get; set; }

    // Parameters se nayi Student object ki properties initialize hoti hain.
    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    // Object ki maloomat dikhata hai.
    public void ShowInformation()
    {
        Console.WriteLine($"{Name} is in grade {Grade}.");
    }
}

class Program
{
    static void Main()
    {
        // Arguments constructor ko bhej kar pehla object banaya.
        Student firstStudent = new Student("Amina", 8);

        // Doosre object ko uski apni initial values di gayin.
        Student secondStudent = new Student("Bilal", 9);

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
 * - using System; Console.WriteLine use karne deta hai.
 * - class Student student object ka naqsha hai.
 * - Name aur Grade properties student ka data rakhti hain.
 * - public Student(string name, int grade) parameterized constructor hai.
 * - name aur grade constructor ke parameters hain.
 * - Name = name; parameter ki value Name property mein set karta hai.
 * - Grade = grade; parameter ki value Grade property mein set karta hai.
 * - ShowInformation() object ki values print karta hai.
 * - static void Main() program ka starting point hai.
 * - new Student("Amina", 8) argument values constructor ko deta hai.
 * - Constructor chalne ke baad firstStudent ki Name Amina aur Grade 8 hai.
 * - Doosra new Student(...) call alag values wala naya object banata hai.
 * - Dono ShowInformation calls har object ki apni values dikhati hain.
 *
 * Parameter vs argument:
 * - Constructor definition mein name aur grade parameters hain.
 * - Constructor call mein "Amina" aur 8 arguments hain.
 *
 * Ahm nuqta:
 * Parameterized constructor likhne par compiler automatic parameterless
 * default constructor nahi deta. Agar dono tareeqon se object banana ho to
 * parameterless constructor bhi khud likhna hota hai.
 *
 * Practice exercises:
 *
 * Beginner 1: Book class ke liye Title parameter lene wala constructor banayein.
 * Beginner 2: Constructor se aik Book object banayein aur Title print karein.
 * Intermediate 1: Product class mein Name aur Price parameters lene wala
 *                 constructor banayein; do products ki details dikhayein.
 * Intermediate 2: Rectangle class ko width aur height constructor se dein
 *                  aur CalculateArea() method se area return karein.
 * Real-world scenario: BankAccount object bante waqt account holder ka naam
 *                      aur initial balance constructor ko dein.
 *
 * Aap ki bari:
 * Book class likhein jismein Title aur Author properties, dono ke parameters
 * lene wala constructor aur ShowDetails() method ho. Main mein do Book objects
 * bana kar details dikhayein. Apna code bhejein; main check karke samjhaunga.
 */

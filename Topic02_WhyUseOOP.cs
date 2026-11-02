using System;

/*
 * Topic 2: Why do we use OOP?
 *
 * Technical definition (English):
 * OOP helps organize related data and behavior into objects, making software
 * easier to understand, reuse, extend, and maintain.
 *
 * Roman English:
 * OOP related data aur actions ko aik object mein rakhta hai. Is se program
 * samajhna, code dobara use karna, naye features add karna, aur ghaltiyan
 * theek karna asaan ho sakta hai.
 *
 * Real-life example:
 * School program mein har student ka naam aur grade uske student object mein
 * rakha ja sakta hai. Student object apni information display bhi kar sakta hai.
 *
 * Syntax:
 * class ClassName
 * {
 *     // Data aur us se related actions
 * }
 *
 * Class aur object ki tafseel aglay topics mein parhenge.
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

class Student
{
    // Har Student object ka naam store karta hai.
    public string Name;

    // Har Student object ka grade store karta hai.
    public int Grade;

    // Is student ki information display karta hai.
    public void ShowInformation()
    {
        Console.WriteLine($"{Name} is in grade {Grade}.");
    }
}

class Program
{
    static void Main()
    {
        // Pehla student object banaya.
        Student firstStudent = new Student();
        firstStudent.Name = "Amina";
        firstStudent.Grade = 8;

        // Doosra student object banaya.
        Student secondStudent = new Student();
        secondStudent.Name = "Bilal";
        secondStudent.Grade = 9;

        // Har object apni information display karta hai.
        firstStudent.ShowInformation();
        secondStudent.ShowInformation();
    }
}

/*
 * Expected output:
 * Amina is in grade 8.
 * Bilal is in grade 9.
 *
 * Code line-by-line:
 * - using System; se Console.WriteLine use kar sakte hain.
 * - class Student student ka naqsha hai.
 * - Name aur Grade har student ka data hain.
 * - ShowInformation() student se related action hai.
 * - class Program program ka entry-point code rakhti hai.
 * - static void Main() se program chalna shuru hota hai.
 * - new Student() aik naya Student object banata hai.
 * - firstStudent.Name aur firstStudent.Grade us object ka data set karte hain.
 * - ShowInformation() us object ka action chalata hai.
 *
 * OOP ke faide:
 * - Related cheezen aik jagah rehti hain.
 * - Aik class se kai objects ban sakte hain.
 * - Program ko chotay, wazeh parts mein organize karna asaan hota hai.
 * - Baray program mein changes aur maintenance asaan ho sakti hai.
 *
 * Yaad rahe: OOP har chotay program ke liye zaroori nahi. Bohat simple kaam
 * procedural code se bhi ho sakte hain; OOP zyada useful tab hota hai jab
 * program mein related entities aur behavior barh rahe hon.
 *
 * Practice exercises:
 *
 * Beginner 1: Student example mein aik teesra student add karein.
 * Beginner 2: ShowInformation ka output apne pasandeeda format mein badlein.
 * Intermediate 1: Student mein Subject naam ka data add karein aur display karein.
 * Intermediate 2: Sochiye ke 100 students ko alag variables se manage karne
 *                  ke bajaye objects banana kyun madadgar hai?
 * Real-world scenario: Library ke books ke liye data (title, author) aur
 *                      action (ShowDetails) ko aik object mein organize karein.
 *
 * Aap ki bari:
 * Book naam ki class ka code likhein. Us mein Title aur Author data hon,
 * ShowDetails action ho, aur Main mein do Book objects bana kar unki
 * information display karein. Apna code bhejein; main check karke samjhaunga.
 */

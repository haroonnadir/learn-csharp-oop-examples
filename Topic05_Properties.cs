using System;

/*
 * Topic 5: Properties
 *
 * Technical definition (English):
 * A property is a class member that provides a controlled way to read or
 * write a value. In C#, properties commonly use get and set accessors.
 *
 * Roman English:
 * Property class ka member hoti hai jo object ki value ko read ya change
 * karne ka tareeqa deti hai. get value parhne ke liye aur set value dene
 * ke liye use hota hai.
 *
 * Real-life example:
 * Student ka naam property se maloom kiya ya set kiya ja sakta hai.
 *
 * Basic syntax:
 * public string Name { get; set; }
 *
 * Is simple form ko auto-implemented property kehte hain; iski tafseel
 * baad ke topic mein dekhenge.
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

class Student
{
    // Property student ka naam read aur write karne deti hai.
    public string Name { get; set; }

    // Property student ka grade read aur write karne deti hai.
    public int Grade { get; set; }

    // Student ki properties ki values dikhata hai.
    public void ShowInformation()
    {
        Console.WriteLine($"{Name} is in grade {Grade}.");
    }
}

class Program
{
    static void Main()
    {
        // Student class ka object banaya.
        Student student = new Student();

        // set accessor ke zariye property values di.
        student.Name = "Amina";
        student.Grade = 8;

        // get accessor ke zariye values parhi jati hain.
        Console.WriteLine($"Student name: {student.Name}");
        student.ShowInformation();
    }
}

/*
 * Expected output:
 * Student name: Amina
 * Amina is in grade 8.
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - class Student student object ka naqsha hai.
 * - public string Name { get; set; } string Name property banati hai.
 * - get property ki value parhne deta hai; set nayi value dene deta hai.
 * - public int Grade { get; set; } number wali Grade property banati hai.
 * - ShowInformation() Name aur Grade ki values display karta hai.
 * - class Program application ka main code rakhta hai.
 * - static void Main() se program chalna shuru hota hai.
 * - new Student() aik Student object banata hai.
 * - student.Name = "Amina" set accessor se naam deta hai.
 * - student.Grade = 8 set accessor se grade deta hai.
 * - student.Name ko Console.WriteLine mein dena get accessor se naam parhta hai.
 * - student.ShowInformation() object ka method chala kar dono values dikhata hai.
 *
 * Property aur field ka bunyaadi farq:
 * - Field seedha class mein data store karta hai, jaise: string name;
 * - Property get/set accessors ke zariye value parhne ya dene ka interface deti hai.
 * - Auto-property ke peechay storage C# khud manage karta hai.
 * - Property mein validation likhna bhi mumkin hai; woh aglay mutaliqa topics
 *   mein detail se parhenge.
 *
 * Practice exercises:
 *
 * Beginner 1: Student mein Age naam ki int property add karein aur print karein.
 * Beginner 2: Name property ko "Bilal" set karein aur updated value display karein.
 * Intermediate 1: Book class banayein jismein Title aur Author properties hon;
 *                 do objects ki details print karein.
 * Intermediate 2: Product class mein Price property add karein aur uski value
 *                  Console.WriteLine se display karein.
 * Real-world scenario: Library book record ke liye Title, Author aur IsAvailable
 *                      properties rakhein; aik book object ki values display karein.
 *
 * Aap ki bari:
 * Product class ka complete console program likhein. Name aur Price properties,
 * ShowDetails() method, aur do mukhtalif product objects banayein. Apna code
 * bhejein; main check karke Roman English mein ghaltiyan samjhaunga.
 */

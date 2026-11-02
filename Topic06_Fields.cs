using System;

/*
 * Topic 6: Fields
 *
 * Technical definition (English):
 * A field is a variable declared directly in a class or struct. Each object
 * usually has its own copy of an instance field.
 *
 * Roman English:
 * Field woh variable hota hai jo class ya struct ke andar seedha declare
 * hota hai. Aam tor par har object ke instance field ki apni value hoti hai.  
 *
 * Real-life example:
 * Har student ka apna naam aur grade ho sakta hai. Student object ke fields
 * un values ko store karte hain.
 *
 * Basic syntax:
 * class ClassName
 * {
 *     private string fieldName;
 * }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

class Student
{
    // Private field class ke andar student ka naam store karta hai.
    private string name;

    // Private field class ke andar student ka grade store karta hai.
    private int grade;

    // Constructor ke zariye fields ko shuru ki values dete hain.
    public Student(string studentName, int studentGrade)
    {
        name = studentName;
        grade = studentGrade;
    }

    // Method fields ki values console par dikhata hai.
    public void ShowInformation()
    {
        Console.WriteLine($"{name} is in grade {grade}.");
    }
}

class Program
{
    static void Main()
    {
        // Do Student objects banaye; har object ke fields alag hain.
        Student firstStudent = new Student("Amina", 8);
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
 * - using System; Console.WriteLine ko available karta hai.
 * - class Student student object ka naqsha hai.
 * - private string name; naam rakhne ke liye field declare karta hai.
 * - private int grade; grade rakhne ke liye field declare karta hai.
 * - public Student(...) constructor hai; object bante waqt yeh chalta hai.
 * - studentName aur studentGrade constructor ko di gayi input values hain.
 * - name = studentName; input naam ko private name field mein rakhta hai.
 * - grade = studentGrade; input grade ko private grade field mein rakhta hai.
 * - ShowInformation() class ke andar fields access karke unhein display karta hai.
 * - static void Main() program ka starting point hai.
 * - new Student("Amina", 8) aik object banata aur uske fields initialize karta hai.
 * - secondStudent ke liye doosra object aur alag field values banti hain.
 * - Dono method calls har object ki apni values display karti hain.
 *
 * Field aur property ka farq:
 * - Field variable hai jo class/struct mein seedha declare hota hai.
 * - Property value parhne ya dene ka controlled interface deti hai.
 * - C# convention ke mutabiq aam tor par fields private rakhe jate hain.
 * - Public data dikhane ke liye aksar property use hoti hai; is se validation
 *   aur access control mumkin hota hai.
 *
 * Practice exercises:
 *
 * Beginner 1: Student class mein private string city field add karein.
 * Beginner 2: Constructor se city ki value dein aur ShowInformation mein print karein.
 * Intermediate 1: BankAccount class mein private decimal balance field rakhein.
 *                 Constructor balance le aur aik method usay display kare.
 * Intermediate 2: Do Book objects banayein jin ke private title fields ki values
 *                  mukhtalif hon; method se dono titles dikhayein.
 * Real-world scenario: Library book record mein private title aur author fields
 *                      store karein aur method se record display karein.
 *
 * Aap ki bari:
 * BankAccount class likhein jismein private balance field ho, constructor
 * starting balance le, aur ShowBalance() method balance dikhaye. Do accounts
 * banayein aur code bhejein; main check karke samjhaunga.
 */

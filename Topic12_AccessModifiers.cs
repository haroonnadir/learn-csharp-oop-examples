using System;

/*
 * Topic 12: Access Modifiers
 *
 * Technical definition (English):
 * Access modifiers are keywords that control where a type or its members can
 * be accessed from.
 *
 * Roman English:
 * Access modifiers C# ke keywords hain jo control karte hain ke class,
 * property ya method ko program ke kin hisson se access kiya ja sakta hai.
 *
 * Real-life example:
 * Ghar mein kuch cheezen sirf ghar ke andar walon ke liye hoti hain, kuch
 * cheezen mehmaan use kar sakte hain, aur kuch shared building ke rehne walon
 * ke liye hoti hain. Modifiers code mein milta-julta access control dete hain.
 *
 * Common access modifiers:
 * - public: har jagah se accessible, jahan type khud accessible ho.
 * - private: sirf usi class/struct ke andar accessible.
 * - protected: usi class aur us se inherit hone wali classes mein accessible.
 * - internal: usi assembly/project ke andar accessible.
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

class Person
{
    // Public property ko doosra code access kar sakta hai.
    public string Name { get; set; }

    // Private field sirf Person class ke andar directly access hota hai.
    private int age;

    // Protected property Person aur derived classes ko available hoti hai.
    protected string Role { get; set; }

    // Internal property isi assembly/project ke andar available hoti hai.
    internal string Department { get; set; }

    public Person(string name, int personAge, string role, string department)
    {
        Name = name;
        age = personAge;
        Role = role;
        Department = department;
    }

    // Person class ke andar private age field ko read karta hai.
    public void ShowAge()
    {
        Console.WriteLine($"Age: {age}");
    }
}

class Teacher : Person
{
    public Teacher(string name, int age, string department)
        : base(name, age, "Teacher", department)
    {
    }

    // Derived class protected Role ko access kar sakti hai.
    public void ShowTeacherDetails()
    {
        Console.WriteLine($"{Name} works as a {Role} in {Department}.");
    }
}

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher("Sara", 32, "Science");

        // Public member ko doosre class se access karte hain.
        Console.WriteLine($"Name: {teacher.Name}");

        // Public method private age field ko class ke andar se dikhata hai.
        teacher.ShowAge();

        // Teacher derived class ke protected member ko use karta hai.
        teacher.ShowTeacherDetails();

        // Internal member isi assembly mein access ho sakta hai.
        Console.WriteLine($"Department: {teacher.Department}");

        // teacher.Role aur teacher.age ko yahan se access nahi kar sakte:
        // Role protected hai aur age private hai.
    }
}

/*
 * Expected output:
 * Name: Sara
 * Age: 32
 * Sara works as a Teacher in Science.
 * Department: Science
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko available karta hai.
 * - class Person common person members define karti hai.
 * - public Name property ko accessible jagah se read/set kar sakte hain.
 * - private age field ko sirf Person class ka code directly access kar sakta hai.
 * - protected Role property Person aur derived class Teacher ke liye accessible hai.
 * - internal Department property isi assembly mein accessible hai.
 * - Person(...) constructor values le kar members initialize karta hai.
 * - ShowAge() private age ko Person class ke andar se display karta hai.
 * - class Teacher : Person ka matlab Teacher, Person se inherit karti hai.
 * - Teacher(...) constructor : base(...) se parent Person constructor call karta hai.
 * - ShowTeacherDetails() inherited public Name aur protected Role aur internal
 *   Department ko access karke display karta hai.
 * - Main() Teacher object banata aur allowed public/internal members use karta hai.
 *
 * Comparison:
 * Modifier   | Kahan accessible?
 * public     | Jahan containing type accessible ho
 * private    | Sirf declaring class/struct ke andar
 * protected  | Declaring class aur derived classes mein
 * internal   | Usi assembly (aam tor par project output) mein
 *
 * Yaad rahe:
 * Top-level class ko aam tor par public ya internal banaya ja sakta hai.
 * Agar class par modifier na likha jaye to top-level class default taur par
 * internal hoti hai. Class members ke liye default access aam tor par private hai.
 *
 * Practice exercises:
 *
 * Beginner 1: Person mein public Email property add karein aur display karein.
 * Beginner 2: private string phone field add karein aur class ke method se print karein.
 * Intermediate 1: Employee base class mein protected EmployeeId rakhein aur
 *                 Manager derived class se usay display karein.
 * Intermediate 2: Apne project ki do classes ke darmiyan internal member access
 *                  ka example likhein.
 * Real-world scenario: Bank account mein balance private rakhein aur usay sirf
 *                      class ke public methods ke zariye read/update karne dein.
 *
 * Aap ki bari:
 * BankAccount class banayein. Private balance field, public Deposit method,
 * aur public ShowBalance method hon. Main se field ko seedha access karne ke
 * bajaye methods use karein. Code bhejein; main check karke samjhaunga.
 */

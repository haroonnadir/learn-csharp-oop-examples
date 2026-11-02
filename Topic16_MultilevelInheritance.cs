using System;

/*
 * Topic 16: Multilevel Inheritance
 *
 * Technical definition (English):
 * Multilevel inheritance is an inheritance chain in which a class derives
 * from a class that itself derives from another class.
 *
 * Roman English:
 * Multilevel inheritance mein inheritance ki chain hoti hai: aik class doosri
 * se inherit karti hai, aur teesri class us child class se inherit karti hai.
 *
 * Real-life example:
 * Animal se Mammal common features leti hai; Dog, Mammal se features leta hai.
 * Is tarah Dog ko Animal aur Mammal dono levels ke accessible features milte hain.
 *
 * Syntax:
 * class A { }
 * class B : A { }
 * class C : B { }
 *
 * C# har class ke liye aik direct base class allow karta hai, lekin aisi
 * multilevel chain banana mumkin hai.
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Animal inheritance chain ki pehli/base class hai.
class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

// Mammal, Animal se inherit karti hai aur apna behavior add karti hai.
class Mammal : Animal
{
    public Mammal(string name) : base(name)
    {
    }

    public void BreatheAir()
    {
        Console.WriteLine($"{Name} breathes air.");
    }
}

// Dog, Mammal se inherit karti hai; chain mein yeh Animal se bhi derived hai.
class Dog : Mammal
{
    public Dog(string name) : base(name)
    {
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

class Program
{
    static void Main()
    {
        // Dog constructor chain se Mammal aur phir Animal constructor tak name jata hai.
        Dog dog = new Dog("Max");

        // Animal level ka inherited method.
        dog.Eat();

        // Mammal level ka inherited method.
        dog.BreatheAir();

        // Dog class ka apna method.
        dog.Bark();
    }
}

/*
 * Expected output:
 * Max is eating.
 * Max breathes air.
 * Max says: Woof!
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - class Animal chain ki base class hai aur Name rakhti hai.
 * - Animal(string name) Name property initialize karta hai.
 * - Eat() Animal ka method hai.
 * - class Mammal : Animal batata hai Mammal, Animal se inherit karti hai.
 * - Mammal(string name) : base(name) parent Animal constructor ko call karta hai.
 * - BreatheAir() Mammal ka apna method hai.
 * - class Dog : Mammal mein Dog, Mammal se inherit karta hai.
 * - Is chain ki wajah se Dog ko Mammal ke zariye Animal ke accessible members bhi milte hain.
 * - Dog(string name) : base(name) Mammal constructor call karta hai; Mammal
 *   apne base constructor Animal ko name deta hai.
 * - Bark() Dog ka apna method hai.
 * - Main() program ka starting point hai.
 * - new Dog("Max") constructors ko chain mein Animal tak chalata hai.
 * - dog.Eat() Animal level ka inherited behavior chalata hai.
 * - dog.BreatheAir() Mammal level ka inherited behavior chalata hai.
 * - dog.Bark() Dog ka apna behavior chalata hai.
 *
 * Faida:
 * Har level par relevant shared behavior rakha ja sakta hai; Dog ko sab
 * accessible inherited members dobara likhne nahi parte.
 *
 * Ehtiyat:
 * Bohat lambi ya ghalat inheritance chain samajhna mushkil bana sakti hai.
 * Har "is-a" relation ko check karein: Dog is a Mammal, Mammal is an Animal.
 *
 * Practice exercises:
 *
 * Beginner 1: Animal mein Sleep() method add karein aur dog se call karein.
 * Beginner 2: Dog mein Fetch() method add karein.
 * Intermediate 1: Person -> Employee -> Manager ki chain banayein. Har level
 *                 par aik relevant property ya method add karein.
 * Intermediate 2: Constructor call chain trace karein: Manager se Employee,
 *                  phir Person constructor tak data kaise pohanchta hai?
 * Real-world scenario: Device -> Computer -> Laptop classes bana kar har level
 *                      par aik munasib common feature rakhein.
 *
 * Aap ki bari:
 * Person -> Employee -> Manager multilevel chain likhein. Person mein Name,
 * Employee mein EmployeeId, Manager mein ApproveLeave() method rakhein.
 * Manager object bana kar teeno levels ke features use karein. Code bhejein;
 * main check karke Roman English mein samjhaunga.
 */

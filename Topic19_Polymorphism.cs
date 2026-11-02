using System;

/*
 * Topic 19: Polymorphism
 *
 * Technical definition (English):
 * Polymorphism means "many forms." In object-oriented programming, it lets
 * different types be used through a common base type or interface while each
 * type can provide its own behavior.
 *
 * Roman English:
 * Polymorphism ka matlab hai "kai forms". Mukhtalif object aik common base
 * type ya interface ke zariye use ho sakte hain, magar har object apna
 * munasib behavior dikha sakta hai.
 *
 * Real-life example:
 * Mukhtalif animals ki awaz nikalne ka action common ho sakta hai. Dog bhonkta
 * hai aur Cat meow karti hai. Caller dono ko Animal samajh kar MakeSound chala
 * sakta hai; asal object ke mutabiq awaz mukhtalif hoti hai.
 *
 * Syntax idea:
 * Animal animal = new Dog();
 * animal.MakeSound(); // Dog ka overridden behavior
 *
 * Is lesson mein runtime polymorphism (virtual/override) ka bunyadi demo hai.
 * Method overloading compile-time polymorphism ke taur par aglay topic mein
 * alag se parhenge.
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Animal common base type hai.
class Animal
{
    // virtual ka matlab derived class is method ka behavior override kar sakti hai.
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Dog Animal ki MakeSound implementation ko apne behavior se replace karta hai.
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

// Cat bhi isi base method ka apna behavior deti hai.
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat says: Meow!");
    }
}

class Program
{
    static void Main()
    {
        // Base type ke references mukhtalif derived objects ko refer karte hain.
        Animal firstAnimal = new Dog();
        Animal secondAnimal = new Cat();

        // Runtime par asal object ka overridden method chalta hai.
        firstAnimal.MakeSound();
        secondAnimal.MakeSound();
    }
}

/*
 * Expected output:
 * Dog says: Woof!
 * Cat says: Meow!
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine use karne deta hai.
 * - class Animal common base class define karti hai.
 * - virtual MakeSound() derived classes ko behavior badalne ki ijazat deta hai.
 * - class Dog : Animal, Dog ko Animal se derive karti hai.
 * - override MakeSound() Dog ki specific awaz deta hai.
 * - class Cat : Animal, Cat ko Animal se derive karti hai.
 * - Cat ka override uska apna sound behavior deta hai.
 * - Main() se program execution shuru hoti hai.
 * - Animal firstAnimal = new Dog(); variable ka declared type Animal hai,
 *   magar asal object Dog hai.
 * - Animal secondAnimal = new Cat(); declared type Animal hai, asal object Cat hai.
 * - firstAnimal.MakeSound() Dog ka override chalata hai.
 * - secondAnimal.MakeSound() Cat ka override chalata hai.
 *
 * Polymorphism yahan kyun hai?
 * Dono calls ka naam MakeSound hai aur dono variables ka declared type Animal
 * hai, lekin output asal object ke mutabiq badalta hai.
 *
 * Compile-time aur runtime:
 * - Compile-time polymorphism ki aam misaal method overloading hai: compiler
 *   parameters dekh kar method choose karta hai.
 * - Runtime polymorphism ki misaal virtual/override hai: runtime asal object
 *   ke mutabiq implementation choose karta hai.
 *
 * Faide:
 * - Caller mukhtalif derived types ko aik common type se use kar sakta hai.
 * - Nayi derived class add karne se common calling code aksar seedha rehta hai.
 *
 * Ehtiyat:
 * - Sirf method name same hona polymorphism nahi hota; yahan base reference aur
 *   virtual/override dispatch behavior badalne mein ahm hain.
 * - Override ke liye base method virtual, abstract, ya override hona chahiye.
 *
 * Practice exercises:
 *
 * Beginner 1: Animal mein virtual Move() method add karein.
 * Beginner 2: Dog ke MakeSound output ko apne alfaaz mein badlein.
 * Intermediate 1: Bird : Animal banayein aur MakeSound override karein.
 * Intermediate 2: Animal[] array mein Dog, Cat aur Bird objects rakh kar loop
 *                  mein har object ka MakeSound call karein.
 * Real-world scenario: PaymentMethod base type se CardPayment aur CashPayment
 *                      alag ProcessPayment behavior dein.
 *
 * Aap ki bari:
 * Shape base class banayein jismein virtual Describe() ho. Circle aur Square
 * derived classes mein Describe() override karein. Dono ko Shape references
 * mein rakh kar unke methods call karein. Code bhejein; main check karunga.
 */

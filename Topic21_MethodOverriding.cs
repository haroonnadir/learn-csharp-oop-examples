using System;

/*
 * Topic 21: Run-Time Polymorphism (Method Overriding)
 *
 * Technical definition (English):
 * Method overriding occurs when a derived class provides a new implementation
 * for an inherited virtual or abstract method. With virtual dispatch, the
 * implementation is selected at runtime according to the object's actual type.
 *
 * Roman English:
 * Method overriding mein child class, parent ke virtual ya abstract method
 * ka apna implementation deti hai. Runtime par asal object jis child class
 * ka ho, usi ka method chalta hai.
 *
 * Real-life example:
 * Har payment method payment process karta hai, magar Card aur Cash ka process
 * mukhtalif ho sakta hai. Common base type ke bawajood asal object ke mutabiq
 * implementation chalti hai.
 *
 * Syntax:
 * class Base { public virtual void Action() { ... } }
 * class Child : Base { public override void Action() { ... } }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Base class virtual method de kar override ki ijazat deti hai.
class PaymentMethod
{
    public virtual void Pay(decimal amount)
    {
        Console.WriteLine($"Processing a generic payment of {amount}.");
    }
}

// CardPayment inherited virtual method ko override karta hai.
class CardPayment : PaymentMethod
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} by card.");
    }
}

// CashPayment bhi apna Pay behavior deta hai.
class CashPayment : PaymentMethod
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} in cash.");
    }
}

class Program
{
    static void Main()
    {
        // Variables ka declared type PaymentMethod hai; asal types mukhtalif hain.
        PaymentMethod card = new CardPayment();
        PaymentMethod cash = new CashPayment();

        // Runtime par asal object ki override implementation chunti hai.
        card.Pay(25m);
        cash.Pay(10m);
    }
}

/*
 * Expected output:
 * Paying 25 by card.
 * Paying 10 in cash.
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ke liye hai.
 * - class PaymentMethod common base class hai.
 * - virtual Pay(...) derived classes ko method override karne deta hai.
 * - class CardPayment : PaymentMethod base se inherit karti hai.
 * - override Pay(...) card payment ka specific behavior deta hai.
 * - class CashPayment : PaymentMethod bhi usi base se inherit karti hai.
 * - CashPayment ka override cash ke liye alag behavior deta hai.
 * - Main() program ka starting point hai.
 * - PaymentMethod card = new CardPayment(); base-type variable ko Card object
 *   refer karwata hai.
 * - PaymentMethod cash = new CashPayment(); doosre base reference mein Cash object hai.
 * - card.Pay(25m) runtime par CardPayment.Pay chalata hai.
 * - cash.Pay(10m) runtime par CashPayment.Pay chalata hai.
 * - m suffix decimal literal ko decimal type banata hai.
 *
 * Overriding ke zaroori rules:
 * - Base method virtual, abstract, ya pehle se override hona chahiye.
 * - Derived method par override keyword use hota hai.
 * - Method signatures compatible honi chahiye.
 * - Access level override mein base method ke access ko restrict nahi kar sakta.
 * - new keyword method hiding karta hai; woh override ka badal nahi.
 *
 * Overloading vs overriding:
 * - Overloading mein same naam ke methods ke parameter lists mukhtalif hote hain.
 * - Overriding mein derived class inherited virtual method ka implementation badalti hai.
 *
 * Practice exercises:
 *
 * Beginner 1: Animal base class mein virtual MakeSound() aur Dog mein override banayein.
 * Beginner 2: Cat class add karein aur MakeSound() ko override karein.
 * Intermediate 1: Shape mein virtual Describe() aur Circle/Square mein overrides banayein;
 *                 base-type references se call karein.
 * Intermediate 2: Agar base method virtual na ho to override keyword kyun error dega?
 *                  Chhota code example likhein.
 * Real-world scenario: Notification base class mein virtual Send() rakhein; Email aur
 *                      Sms derived classes usay apne tareeqe se implement karein.
 *
 * Aap ki bari:
 * Notification base class mein virtual Send() method banayein. EmailNotification
 * aur SmsNotification mein Send() override karein. Dono objects ko base-type
 * variables mein rakh kar Send() call karein. Code bhejein; main check karunga.
 */

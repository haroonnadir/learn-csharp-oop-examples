using System;

/*
 * Topic 22: Virtual Methods
 *
 * Technical definition (English):
 * A virtual method is a non-static base-class method that provides a default
 * implementation and allows a derived class to replace that implementation
 * using override.
 *
 * Roman English:
 * Virtual method parent class ka aisa non-static method hai jo default
 * implementation deta hai aur child class ko override se apna behavior dene
 * ki ijazat deta hai.
 *
 * Real-life example:
 * Har notification default message bhej sakti hai. Email aur SMS notification
 * apne tareeqe se Send method override kar sakti hain.
 *
 * Syntax:
 * public virtual void MethodName() { ... }
 * public override void MethodName() { ... }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Base class virtual method ka default behavior deti hai.
class Notification
{
    public virtual void Send()
    {
        Console.WriteLine("Sending a general notification.");
    }
}

// EmailNotification optional taur par default behavior override karti hai.
class EmailNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending an email notification.");
    }
}

// Is derived class mein Send override nahi kiya, is liye base behavior use hota hai.
class AppNotification : Notification
{
}

class Program
{
    static void Main()
    {
        Notification email = new EmailNotification();
        Notification app = new AppNotification();

        // Email object ka override chalta hai.
        email.Send();

        // AppNotification ne override nahi kiya; inherited default chalta hai.
        app.Send();
    }
}

/*
 * Expected output:
 * Sending an email notification.
 * Sending a general notification.
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - class Notification base class hai.
 * - virtual void Send() default behavior deta hai aur override allow karta hai.
 * - class EmailNotification : Notification base class se inherit karti hai.
 * - override void Send() Email ke liye apna behavior deta hai.
 * - class AppNotification : Notification inherit karti hai, lekin override nahi karti.
 * - Main() program ka starting point hai.
 * - Notification email = new EmailNotification(); base reference mein email object hai.
 * - Notification app = new AppNotification(); base reference mein app object hai.
 * - email.Send() runtime par EmailNotification ka override chalata hai.
 * - app.Send() runtime par AppNotification mein override na honay ki wajah se base method chalata hai.
 *
 * Ahm rules:
 * - virtual method class ka instance method hota hai; static method virtual nahi hota.
 * - Base method par virtual likha jata hai; derived method par override.
 * - Derived class override na kare to inherited virtual implementation chalti hai.
 * - Abstract method mein body nahi hoti aur concrete derived class ko usay implement
 *   karna hota hai; abstract methods alag topic mein parhenge.
 * - sealed override aage wali derived classes ko us method ko dobara override
 *   karne se rok sakta hai; sealed methods alag topic mein aayenge.
 *
 * Practice exercises:
 *
 * Beginner 1: Animal class mein virtual Move() method likhein.
 * Beginner 2: Bird : Animal banayein aur Move() override karke fly ka message dein.
 * Intermediate 1: Report base class mein virtual Print() aur Invoice derived
 *                 class mein override banayein.
 * Intermediate 2: Aik derived class ko override na karne dein aur output ka
 *                  default behavior samjhayen.
 * Real-world scenario: Logger base class ka virtual Write() default console
 *                      output kare; FileLogger usay apne tareeqe se override kare.
 *
 * Aap ki bari:
 * Shape base class banayein jismein virtual Draw() default message print kare.
 * Circle class Draw() override kare aur Rectangle class override na kare.
 * Dono objects se Draw() chalayein aur code bhejein; main check karunga.
 */

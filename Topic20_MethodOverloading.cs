using System;

/*
 * Topic 20: Compile-Time Polymorphism (Method Overloading)
 *
 * Technical definition (English):
 * Method overloading is defining multiple methods with the same name in one
 * type but with different parameter lists. The compiler selects an overload
 * based on the arguments and their types.
 *
 * Roman English:
 * Method overloading mein aik class ke andar same naam ke multiple methods
 * hote hain, magar unke parameters ki tadaad, types, ya order mukhtalif hota
 * hai. Compiler method call dekh kar munasib overload select karta hai.
 *
 * Real-life example:
 * Calculator ka Add action do whole numbers ya teen whole numbers jama kar
 * sakta hai. Naam aik hai, input options mukhtalif hain.
 *
 * Syntax:
 * int Add(int a, int b) { ... }
 * int Add(int a, int b, int c) { ... }
 *
 * Sirf return type ya parameter names badalne se valid overload nahi banta.
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

class Calculator
{
    // Overload 1: do int parameters leta hai.
    public int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    // Overload 2: teen int parameters leta hai.
    public int Add(int firstNumber, int secondNumber, int thirdNumber)
    {
        return firstNumber + secondNumber + thirdNumber;
    }

    // Overload 3: do decimal parameters leta hai.
    public decimal Add(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber + secondNumber;
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        // Do arguments: compiler do-int overload select karta hai.
        Console.WriteLine($"7 + 5 = {calculator.Add(7, 5)}");

        // Teen arguments: compiler teen-int overload select karta hai.
        Console.WriteLine($"2 + 3 + 4 = {calculator.Add(2, 3, 4)}");

        // Decimal arguments: compiler decimal overload select karta hai.
        Console.WriteLine($"1.5 + 2.25 = {calculator.Add(1.5m, 2.25m)}");
    }
}

/*
 * Expected output:
 * 7 + 5 = 12
 * 2 + 3 + 4 = 9
 * 1.5 + 2.25 = 3.75
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine use karne deta hai.
 * - class Calculator overloaded Add methods ko group karti hai.
 * - Pehla Add do int values leta aur int sum return karta hai.
 * - Doosra Add teen int values leta aur unka sum return karta hai.
 * - Teesra Add do decimal values leta aur decimal sum return karta hai.
 * - class Program application ka main code rakhti hai.
 * - static void Main() program ka starting point hai.
 * - new Calculator() aik calculator object banata hai.
 * - Add(7, 5) mein do int arguments hain, is liye do-int overload chalta hai.
 * - Add(2, 3, 4) mein teen arguments hain, is liye teen-int overload chalta hai.
 * - 1.5m aur 2.25m decimal literals hain; m suffix decimal type dikhata hai.
 * - Add(1.5m, 2.25m) do-decimal overload select karta hai.
 *
 * Overloading vs overriding:
 * - Overloading: same class/type mein same method name, mukhtalif parameter list;
 *   aam tor par compile-time par select hoti hai.
 * - Overriding: derived class virtual/abstract base method ki implementation
 *   badalti hai; runtime par asal object ka behavior select hota hai.
 *
 * Ahm nuqta:
 * Return type akela overload ko alag nahi banata. Misal ke taur par int Add(int)
 * aur string Add(int) aik hi class mein overload ke taur par allowed nahi.
 *
 * Practice exercises:
 *
 * Beginner 1: Calculator mein Multiply(int, int) method likhein.
 * Beginner 2: Add ke liye teen int parameters wala overload add karein.
 * Intermediate 1: Display method ke overloads banayein jo aik string, do strings,
 *                 aur aik int accept karein.
 * Intermediate 2: RectangleArea ke overloads banayein: square ke liye aik
 *                  parameter aur rectangle ke liye do parameters.
 * Real-world scenario: Report method overload karein jo sirf title ya title
 *                      aur page count ke saath report details print kare.
 *
 * Aap ki bari:
 * Calculator mein Multiply ke overloads likhein: do int parameters wala aur
 * teen int parameters wala. Main se dono call karke results print karein.
 * Apna code bhejein; main check karke Roman English mein samjhaunga.
 */

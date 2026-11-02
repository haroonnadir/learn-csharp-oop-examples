using System;

/*
 * Topic 7: Methods
 *
 * Technical definition (English):
 * A method is a named block of code that performs an operation. It can accept
 * input through parameters and can return a result.
 *
 * Roman English:
 * Method code ka naam diya hua hissa hota hai jo koi kaam karta hai.
 * Method input parameters le sakta hai aur result wapas de sakta hai.
 *
 * Real-life example:
 * Calculator ka Add action do numbers leta hai aur unka sum deta hai.
 *
 * Basic syntax:
 * returnType MethodName(parameterType parameterName)
 * {
 *     // Kaam
 *     return value; // Sirf jab returnType void na ho
 * }
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

class Calculator
{
    // Do int values leta hai aur unka sum int ke taur par return karta hai.
    public int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    // Aik greeting print karta hai, lekin koi value return nahi karta.
    public void ShowGreeting(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

class Program
{
    static void Main()
    {
        // Calculator object banaya.
        Calculator calculator = new Calculator();

        // Method ko arguments diye aur returned sum variable mein rakha.
        int total = calculator.Add(7, 5);
        Console.WriteLine($"7 + 5 = {total}");

        // String argument ke saath void method chalaya.
        calculator.ShowGreeting("Amina");
    }
}

/*
 * Expected output:
 * 7 + 5 = 12
 * Hello, Amina!
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine use karne deta hai.
 * - class Calculator methods ka naqsha hai.
 * - public int Add(...) ka matlab method int result dega.
 * - firstNumber aur secondNumber parameters hain: method ke input names.
 * - return firstNumber + secondNumber; sum caller ko wapas deta hai.
 * - public void ShowGreeting(...) method greeting dikhata hai.
 * - void ka matlab method koi value return nahi karta.
 * - string name method ko text input dene wala parameter hai.
 * - static void Main() se program execution shuru hoti hai.
 * - new Calculator() aik calculator object banata hai.
 * - calculator.Add(7, 5) method ko 7 aur 5 arguments ke taur par deta hai.
 * - Add ka returned result total variable mein store hota hai.
 * - Console.WriteLine total ki value print karta hai.
 * - ShowGreeting("Amina") method ko Amina argument dekar greeting dikhata hai.
 *
 * Parameter aur argument:
 * - Parameter method definition ke andar input ka naam hota hai, jaise name.
 * - Argument method call ke waqt di hui asal value hoti hai, jaise "Amina".
 *
 * Yaad rahe:
 * - void method kaam kar sakta hai magar value wapas nahi deta.
 * - int, string ya doosra return type batata hai ke method kis type ki value dega.
 * - Method tab chalta hai jab usay call kiya jaye.
 *
 * Practice exercises:
 *
 * Beginner 1: Calculator mein Subtract method banayein jo do int ka farq return kare.
 * Beginner 2: ShowGreeting mein apna pasandeeda naam argument ke taur par dein.
 * Intermediate 1: Rectangle class mein CalculateArea method banayein jo width aur
 *                 height parameters le aur area return kare.
 * Intermediate 2: Student class mein PrintResult method banayein jo name aur mark
 *                  le aur aik formatted message print kare.
 * Real-world scenario: Shopping cart ka method quantity aur unit price le aur
 *                      total cost return kare.
 *
 * Aap ki bari:
 * Calculator mein Multiply method likhein jo do int parameters le aur unka
 * product return kare. Main mein method call karke result display karein.
 * Apna code bhejein; main check karke Roman English mein samjhaunga.
 */

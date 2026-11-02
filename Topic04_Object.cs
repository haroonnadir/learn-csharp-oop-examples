using System;

/*
 * Topic 4: Object
 *
 * Technical definition (English):
 * An object is an instance of a class. It has its own identity and can hold
 * data and use the behavior described by its class.
 *
 * Roman English:
 * Object class se banne wali asal instance hoti hai. Har object ki apni
 * pehchan aur apna data ho sakta hai, aur woh class ke diye hue actions
 * use kar sakta hai.
 *
 * Real-life example:
 * Ghar ka naqsha class hai. Us naqshay se bana hua har alag ghar object hai.
 * Gharon ka design milta-julta ho sakta hai, lekin address ya rang alag ho sakta hai.
 *
 * Basic syntax:
 * ClassName objectName = new ClassName();
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

// Car class object banane ka naqsha hai.
class Car
{
    // Har Car object ka apna model hoga.
    public string Model;

    // Har Car object ka apna rang hoga.
    public string Color;

    // Is car object ki maloomat dikhata hai.
    public void ShowDetails()
    {
        Console.WriteLine($"{Color} {Model}");
    }
}

class Program
{
    static void Main()
    {
        // new Car() aik naya object banata hai.
        // myCar us object ko refer karne wala variable hai.
        Car myCar = new Car();
        myCar.Model = "Civic";
        myCar.Color = "Blue";

        // Doosra object alag data rakhta hai.
        Car yourCar = new Car();
        yourCar.Model = "Corolla";
        yourCar.Color = "White";

        // Har object apni maloomat dikhata hai.
        myCar.ShowDetails();
        yourCar.ShowDetails();
    }
}

/*
 * Expected output:
 * Blue Civic
 * White Corolla
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ke liye zaroori namespace lata hai.
 * - class Car aik type/naqsha define karti hai.
 * - Model aur Color har car ka data rakhte hain.
 * - ShowDetails() object ka action hai.
 * - class Program program ka entry-point code rakhti hai.
 * - static void Main() se program execution shuru hoti hai.
 * - Car myCar = new Car(); naya Car object banata hai aur myCar mein uska
 *   reference rakhta hai.
 * - myCar.Model aur myCar.Color pehle object ka data set karte hain.
 * - Car yourCar = new Car(); aik naya, doosra Car object banata hai.
 * - yourCar.Model aur yourCar.Color doosre object ka data set karte hain.
 * - Dono ShowDetails calls apne apne object ki values display karti hain.
 *
 * Ahm farq:
 * Class type/naqsha hoti hai; object us class ki bani hui instance hoti hai.
 * myCar aur yourCar do alag object references hain, aur dono apna data rakhte hain.
 *
 * Practice exercises:
 *
 * Beginner 1: Is example mein aik teesra Car object add karein.
 * Beginner 2: Pehli car ka color badlein aur naya output note karein.
 * Intermediate 1: Phone class banayein; do phone objects ko mukhtalif Brand
 *                 aur Model values dein, phir details print karein.
 * Intermediate 2: Apne alfaaz mein samjhayen ke aik class se kai objects kyun
 *                  banaye ja sakte hain aur unka data alag kaise rehta hai.
 * Real-world scenario: Online store ke liye Product class se do alag products
 *                      banayein; har product ka naam aur price alag ho.
 *
 * Aap ki bari:
 * Phone class ka complete program likhein. Brand aur Model ka data rakhein,
 * ShowDetails() method banayein, do objects bana kar dono ki details dikhayein.
 * Code bhejein; main check karke Roman English mein samjhaunga.
 */

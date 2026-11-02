using System;

/*
 * Topic 13: Encapsulation
 *
 * Technical definition (English):
 * Encapsulation is the practice of keeping an object's state together with its
 * behavior and controlling access to that state through a defined public
 * interface.
 *
 * Roman English:
 * Encapsulation mein object ka data aur us data par kaam karne wale methods
 * aik class mein rakhe jate hain. Data ko seedha badalne ke bajaye, public
 * methods ya properties ke zariye controlled access diya jata hai.
 *
 * Why we use it:
 * Data ko invalid values se bachane, rules aik jagah rakhne, aur class ke
 * internal details ko chhupane ke liye.
 *
 * Real-life example:
 * Bank account ka balance customer seedha set nahi karta. Woh deposit ya
 * withdrawal karta hai; bank ke rules amount aur available balance check karte hain.
 *
 * Run karne ka tareeqa:
 *   dotnet new console -n OopLesson
 *   Is file ka code OopLesson ke Program.cs mein paste karein.
 *   dotnet run --project OopLesson
 */

class BankAccount
{
    // Private field ko class ke bahar se seedha badla nahi ja sakta.
    private decimal balance;

    // Read-only property balance dekhne deti hai, magar seedha set nahi karne deti.
    public decimal Balance
    {
        get { return balance; }
    }

    // Deposit sirf positive amount qabool karta hai.
    public bool Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return false;
        }

        balance += amount;
        return true;
    }

    // Withdrawal positive ho aur available balance se zyada na ho.
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > balance)
        {
            return false;
        }

        balance -= amount;
        return true;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        if (account.Deposit(500))
        {
            Console.WriteLine("Deposit accepted.");
        }

        if (account.Withdraw(120))
        {
            Console.WriteLine("Withdrawal accepted.");
        }

        Console.WriteLine($"Balance: {account.Balance}");

        if (!account.Withdraw(1000))
        {
            Console.WriteLine("Withdrawal rejected: insufficient balance.");
        }

        // Yeh direct assignment compile nahi hogi:
        // account.balance = 1000000; // balance private hai
        // account.Balance = 1000000; // Balance property read-only hai
    }
}

/*
 * Expected output:
 * Deposit accepted.
 * Withdrawal accepted.
 * Balance: 380
 * Withdrawal rejected: insufficient balance.
 *
 * Line-by-line samajh:
 * - using System; Console.WriteLine ko use karne deta hai.
 * - class BankAccount account ka data aur us par allowed operations rakhti hai.
 * - private decimal balance; account ka asal balance chhupa kar rakhta hai.
 * - public decimal Balance property sirf get deti hai, set nahi.
 * - Deposit(decimal amount) deposit amount input leta hai.
 * - amount <= 0 ho to false return hota hai; balance tabdeel nahi hota.
 * - balance += amount; valid amount balance mein jama karta hai.
 * - return true; batata hai ke deposit kamyab hua.
 * - Withdraw(decimal amount) withdrawal amount input leta hai.
 * - amount <= 0 ya amount > balance ho to request reject hoti hai.
 * - balance -= amount; valid amount balance se minus karta hai.
 * - Main() mein BankAccount ka naya object banaya jata hai.
 * - Deposit(500) true deta hai, is liye accepted message print hota hai.
 * - Withdraw(120) true deta hai; balance 500 se 380 ho jata hai.
 * - account.Balance se read-only property ke zariye current balance parha jata hai.
 * - Withdraw(1000) false deta hai kyun ke balance sirf 380 hai.
 * - Aakhri commented lines jaan-boojh kar invalid hain: private field aur
 *   read-only property ko bahar se set karne ki koshish compile nahi hoti.
 *
 * Encapsulation ke faide:
 * - Object ka data invalid direct changes se mehfooz rehta hai.
 * - Validation rules Deposit/Withdraw jaisi methods mein aik jagah hotay hain.
 * - Class ka internal implementation badalne par callers ko kam asar hota hai.
 *
 * Nuqsanat / trade-offs:
 * - Chhoti class mein extra methods/properties se code zyada ho sakta hai.
 * - Rules ko theek design na kiya jaye to access be-wajah mushkil ho sakta hai.
 *
 * Important:
 * Encapsulation sirf data ko private karna nahi; asal maqsad valid access
 * provide karna aur object ke rules/invariants ko barqarar rakhna hai.
 *
 * Practice exercises:
 *
 * Beginner 1: BankAccount mein public AccountHolder property add karein.
 * Beginner 2: Deposit karne ke baad balance display karein.
 * Intermediate 1: Withdraw method ko change karein taa-ke zero ya negative
 *                  amounts qabool na hon aur balance negative na ho.
 * Intermediate 2: Temperature class mein private Celsius field aur controlled
 *                  property/method banayein jo invalid temperature reject kare.
 * Real-world scenario: Inventory item ka stock private rakhein aur sirf
 *                      AddStock/RemoveStock methods se valid tabdeeli karein.
 *
 * Aap ki bari:
 * InventoryItem class likhein. Private stock field, read-only Stock property,
 * AddStock(int amount), aur RemoveStock(int amount) methods hon. Zero/negative
 * amount reject karein aur stock ko negative na hone dein. Code bhejein;
 * main check karke ghaltiyan Roman English mein samjhaunga.
 */

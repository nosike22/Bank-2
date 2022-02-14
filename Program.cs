using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            account account1 = new account("Nosike Franklin", 500.00m);
            account account2 = new account("Naomi Nosike",300.00m);
            account account3 = new account("Sophia Nosike",100.00m);

            Console.WriteLine($"{account1.Name} Has a balance : {account1.balance}");
            Console.WriteLine($"{account2.Name} Has a balance : {account2.balance}");
            Console.WriteLine($"{account3.Name} Has a balance : {account3.balance}");

            Console.WriteLine("\nEnter the amount you want to deposit into account1:");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount: C}to account1 balance/n");
            account1.Deposit(depositAmount);

            Console.WriteLine($"{account1.Name} Has a balance : {account1.balance}");
            Console.WriteLine($"{account2.Name} Has a balance : {account2.balance}");
            Console.WriteLine($"{account3.Name} Has a balance : {account3.balance}");

            Console.WriteLine("\nEnter the amount you want to deposit into account2:");
             depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount: C}to account2 balance/n");
            account2.Deposit(depositAmount);


            Console.WriteLine($"{account1.Name} Has a balance : {account1.balance}");
            Console.WriteLine($"{account2.Name} Has a balance : {account2.balance}");
            Console.WriteLine($"{account3.Name} Has a balance : {account3.balance}");

            Console.WriteLine("\nEnter the amount you want to deposit into account3:");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount: C}to account3 balance/n");
            account3.Deposit(depositAmount);

            Console.WriteLine($"{account1.Name} Has a balance : {account1.balance}");
            Console.WriteLine($"{account2.Name} Has a balance : {account2.balance}");
            Console.WriteLine($"{account3.Name} Has a balance : {account3.balance}");







            Console.ReadKey();

        }
    }
}

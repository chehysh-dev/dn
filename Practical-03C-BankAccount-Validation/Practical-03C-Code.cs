using System;

namespace bankaccount
{
    class BankAccount
    {
        // Private field for account number
        private string accountnumber;

        // Property for AccountNumber
        public string AccountNumber
        {
            get { return accountnumber; }
            set { accountnumber = value; }
        }

        // Private field for balance
        private double balance;

        // Property with validation
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
            }
        }

        // Constructor
        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        // Method to display account details
        public void Display()
        {
            Console.WriteLine("\nAccount Details");
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Account Number: ");
            string accNo = Console.ReadLine();

            Console.Write("Enter Balance: ");
            double bal = Convert.ToDouble(Console.ReadLine());

            BankAccount account = new BankAccount(accNo, bal);
            account.Display();

            Console.ReadKey();
        }
    }
}

using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            // static variable names are referenced by the class name
            Console.WriteLine("At the beginning, BankAccounts has a value of: {0}", BankAccount.NumberAccounts);

            Console.WriteLine();
            Console.WriteLine("First we create a  new empty account");

            BankAccount firstBankAccount = new BankAccount(); // by calling the simple constructor

            Console.WriteLine("Now, BankAccounts has a value of: {0}", BankAccount.NumberAccounts);

            Console.WriteLine();
            Console.WriteLine("Second, we create a new account with values"); // by calling the other constructor

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter first deposit: ");
            decimal balance = Convert.ToInt32(Console.ReadLine());

            BankAccount secondBankAccount = new BankAccount(lastName, firstName, balance);
            Console.WriteLine();

            Console.WriteLine("Now BankAccounts has a value of: {0}", BankAccount.NumberAccounts);
            Console.WriteLine();

            Console.WriteLine("Now we will display values of both accounts");

            Display(firstBankAccount, secondBankAccount);
            Console.WriteLine();


            Console.WriteLine("Next we will add information to first account using the props and method.");
            Console.Write("Enter a first name: ");
            firstBankAccount.OwnerFirstName = Console.ReadLine();
            Console.Write("Enter a last name: ");
            firstBankAccount.OwnerLastName = Console.ReadLine();
            Console.Write("Enter a deposit amount: ");
            firstBankAccount.Deposit(Convert.ToDecimal(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Now we will display values of both accounts again");
            Display(firstBankAccount, secondBankAccount);

            Console.WriteLine();
            Console.WriteLine("Now BankAccounts has a value of: {0}", BankAccount.NumberAccounts);


            Console.ReadLine();
        }

        private static void Display(BankAccount aBankAccount, BankAccount bBankAccount)
        {
            Console.WriteLine("The first bank account has these values:");
            Console.WriteLine(aBankAccount.OwnerFullName + "  " + aBankAccount.Balance);
            Console.WriteLine();
            Console.WriteLine("The second bank account has these values:");
            Console.WriteLine(bBankAccount.OwnerFullName + "  " + bBankAccount.Balance);
        }
    }
}

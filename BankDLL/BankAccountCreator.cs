using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDLL
{
    internal static class BankAccountCreator
    {
        public static HashSet<BankAccount> AllAccounts;
        public static int CreateAccount()
        {
            BankAccount bankAccount = new BankAccount();
            AllAccounts.Add(bankAccount);
            return bankAccount.GetNumber();
        }
        public static int CreateAccount(int newBalance)
        {
            BankAccount bankAccount = new BankAccount(newBalance);
            AllAccounts.Add(bankAccount);
            return bankAccount.GetNumber();
        }
        public static int CreateAccount(AccountType newType)
        {
            BankAccount bankAccount = new BankAccount(newType);
            AllAccounts.Add(bankAccount);
            return bankAccount.GetNumber(); 
        }
        public static int CreateAccount(AccountType newType, int newBalance)
        {
            BankAccount bankAccount = new BankAccount(newType, newBalance);
            AllAccounts.Add(bankAccount);
            return bankAccount.GetNumber();
        }
        public static void DeleteAccount(int number)
        {
            foreach (BankAccount account in AllAccounts)
            {
                if (account.GetNumber() == number)
                    AllAccounts.Remove(account);
            }
        }
    }
}

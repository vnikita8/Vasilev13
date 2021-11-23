using System;
using System.Collections.Generic;
using System.IO;

namespace CustomBank
{
    public enum AccountType { текущий, сберегательный }
    public class BankAccount
    {
        public static int id = 1;

        private int accountNumber;
        private int balance;
        private AccountType type;
        private Queue<BankTransaction> Transactions = new Queue<BankTransaction>();

        public BankAccount()
        {
            accountNumber = id;
            idPlus();
        }
        public BankAccount(int newBalance)
        {
            balance = newBalance;
            accountNumber = id;
            idPlus();
        }
        public BankAccount(AccountType newType)
        {
            type = newType;
            accountNumber = id;
            idPlus();
        }
        public BankAccount(AccountType newType, int newBalance)
        {
            balance = newBalance;
            type = newType;
            accountNumber = id;
            idPlus();
        }

        public void Dispose(string filepath)
        {
            StreamWriter streamWriter = new StreamWriter(filepath);
            int index = 0;
            foreach (BankTransaction transaction in Transactions)
            {
                streamWriter.WriteLine($"({index}): {transaction.TransferMoney}");
                index++;
            }
            streamWriter.Close();
            GC.SuppressFinalize(this); //вызвать метод GC.SuppressFinalize
        }

        public void PutMoney(int count)
        {
            balance += count;
            Transactions.Enqueue(new BankTransaction(count));
        }

        public bool TryTakeMoney(int count)
        {
            if (count > balance | count < 0) { return false; }
            else
            {
                balance -= count;
                Transactions.Enqueue(new BankTransaction(count));
                return true;
            }
        }

        private static void idPlus() { id++; }
        public int GetBalance() { return balance; }
        public AccountType GetType() { return type; }
        public int GetNumber() { return accountNumber; }

        public static bool TryMoneyTransfer(ref BankAccount accountFrom, ref BankAccount accountTo, int money)
        {
            if (accountFrom.GetNumber() != accountTo.GetNumber())
            {
                if (accountFrom.TryTakeMoney(money))
                {
                    accountTo.PutMoney(money);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public Queue<BankTransaction> getTransactions()
        {
            return Transactions;
        }
        // (Удалено)  public void ChangeBalance(int money) {this.balance = money;}  (Удалено)//
        // (Удалено)  public void ChangeType(AccountType type) {this.type = type;}  (Удалено)//
    }
}
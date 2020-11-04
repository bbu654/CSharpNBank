using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    public class Account
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in AllTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        public Account(string name, decimal initialBalance)    // Form or Template
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = name;
            Deposit(initialBalance, DateTime.Now, "Initial Balance");
        }
        List<Transaction> AllTransactions = new List<Transaction>();
        private static int accountNumberSeed = 1234567890;
        public void Deposit(decimal amount, DateTime date, string note)
        {
            if (IsAmountNegative0(amount)) { }
            else
            {
                Transaction deposit = new Transaction(amount, date, note);
                AllTransactions.Add(deposit);
                if (note != "Initial Balance")
                    Console.WriteLine($"Deposit    of {amount}, Balance={Balance}");
            }
        }
        public void Withdrawal(decimal amount, DateTime date, string note)
        {
            if (IsAmountNegative0(amount) || IsBalanceMinusAmountLessThanZero(amount)) { }
            else
            {
                Transaction withdrawal = new Transaction(-amount, date, note);
                AllTransactions.Add(withdrawal);
                Console.WriteLine($"Withdrawal of {amount}, Balance={Balance}");
            }
        }
        public bool IsAmountNegative0(decimal amount)
        {
            if (amount <= 0)
            {                //throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive!");
                ConsoleColor ForeGroundDefault = Console.ForegroundColor; Console.ForegroundColor = ConsoleColor.Red;
                ConsoleColor BackGroundDefault = Console.BackgroundColor; Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"Amt({amount}) is NOT positive");
                Console.BackgroundColor = BackGroundDefault; Console.ForegroundColor = ForeGroundDefault;
                return true;
            }
            else { return false; }
        }
        public bool IsBalanceMinusAmountLessThanZero(decimal amount)
        {
            if (Balance - amount < 0)
            {                //throw new InvalidOperationException("Not sufficient funds for this Withdrawal!");
                ConsoleColor ForeGroundDefault = Console.ForegroundColor; Console.ForegroundColor = ConsoleColor.Red;
                ConsoleColor BackGroundDefault = Console.BackgroundColor; Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"This amt({amount}) will make Bal({Balance}) < 0");
                Console.BackgroundColor = BackGroundDefault; Console.ForegroundColor = ForeGroundDefault;
                return true;
            }
            else { return false; }
        }
        public void GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in AllTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }
            ConsoleColor ForeGroundDefault = Console.ForegroundColor; Console.ForegroundColor = ConsoleColor.Blue;
            ConsoleColor BackGroundDefault = Console.BackgroundColor; Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(report.ToString());
            Console.BackgroundColor = BackGroundDefault; Console.ForegroundColor = ForeGroundDefault;
        }
    }
}

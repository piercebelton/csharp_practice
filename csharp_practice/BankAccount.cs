using System;
namespace csharp_practice
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        private static int accountNumberSeed = 0000000001;

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            
        }

        public void MakeWithdrawl(decimal amount, DateTime date, string payee, string note)
        {
            
        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }
    }
}

using System;

namespace Тумаков_8лаб
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void TransferMoney(BankAccount Account, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма для перевода должна быть положительной.");
                return;
            }

            if (Balance < amount)
            {
                Console.WriteLine("На вашем счету недостаточно средств для перевода.");
                return;
            }

            Balance -= amount;
            Account.Balance += amount;

            Console.WriteLine($"Переведено {amount} со счета {AccountNumber} на счет {Account.AccountNumber}\nБаланс на счетe: {Account.Balance}");
        }
    }
}

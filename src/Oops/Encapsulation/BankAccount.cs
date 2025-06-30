// This namespace organizes our code within the Encapsulation project.
namespace Oops.Encapsulation
{
    // This class represents a bank account.
    // It demonstrates ENCAPSULATION.
    public class BankAccount
    {
        // This is a private field to store the account balance.
        // 'private' means it can only be accessed from within this class.
        // This is the core of encapsulation - protecting the data.
        private decimal balance;

        // This is the constructor for the BankAccount class.
        // It's called when a new BankAccount object is created.
        // We initialize the balance here.
        public BankAccount(decimal initialBalance)
        {
            // We check if the initial balance is valid.
            if (initialBalance >= 0)
            {
                // If valid, we set the balance.
                balance = initialBalance;
            }
            else
            {
                // If not valid, we set the balance to 0 and inform the user.
                balance = 0;
                // We use Console.WriteLine to output messages to the console.
                Console.WriteLine("Initial balance cannot be negative. Balance set to 0.");
            }
        }

        // This is a public method to deposit money into the account.
        // 'public' means it can be called from anywhere.
        public void Deposit(decimal amount)
        {
            // We check if the deposit amount is valid.
            if (amount > 0)
            {
                // We add the amount to the balance.
                balance = balance + amount;
                // We confirm the deposit.
                Console.WriteLine($"Deposited {amount:C}.");
            }
            else
            {
                // We inform the user if the amount is invalid.
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // This is a public method to withdraw money from the account.
        public void Withdraw(decimal amount)
        {
            // We check if the withdrawal amount is valid.
            if (amount > 0)
            {
                // We check if there are sufficient funds.
                if (amount <= balance)
                {
                    // We subtract the amount from the balance.
                    balance = balance - amount;
                    // We confirm the withdrawal.
                    Console.WriteLine($"Withdrew {amount:C}.");
                }
                else
                {
                    // We inform the user if there are not enough funds.
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                // We inform the user if the amount is invalid.
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        // This is a public method to get the current balance.
        // It provides controlled read-only access to the balance.
        public decimal GetBalance()
        {
            // It returns the current value of the balance.
            return balance;
        }
    }
}

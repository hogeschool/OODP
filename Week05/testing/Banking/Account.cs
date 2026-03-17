public class Account
{
    public List<Transaction> Transactions = new();

    public void Deposit(double amount)
    {
        Transactions.Add(new Transaction(amount));
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            amount = Math.Abs(amount);
        }

        if (amount > GetBalance())
        {
            throw new InvalidOperationException("Insufficient funds");
        }

        Transactions.Add(new Transaction(amount, false));
    }

    public double GetBalance()
    {
        double balance = 0;
        foreach (Transaction transaction in Transactions)
        {
            if (transaction.Credit)
            {
                balance += transaction.Amount;
            }
            else
            {
                balance -= transaction.Amount;
            }
        }
        return balance;
    }

    public void PrintWarningWhenNegativeBalance()
    {
        if (GetBalance() < 0)
        {
            Console.WriteLine("Warning: Negative balance");
        }
    }
    public void Transfer(double amount, Account destination)
    {
        if (amount > GetBalance())
        {
            throw new InvalidOperationException("Insufficient funds");
        }

        Withdraw(amount);
        destination.Deposit(amount);
    }
    
}

public class Transaction
{
    public double Amount;
    public bool Credit;

    public Transaction(double amount, bool credit = true)
    {
        this.Amount = amount;
        this.Credit = credit;
    }
}

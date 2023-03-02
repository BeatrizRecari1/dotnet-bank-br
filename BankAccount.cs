public class BankAccount
{


    public string customerName = "";
    private double balance = 0;


    // Default constructor 
    public BankAccount()
    {
        customerName = "Bob";
        balance = 300;

    }
    public void deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new Exception("No negative deposits allowed");
        }
        {
            balance += amount;
        }
    }

    public double getBalance()
    {
        return balance;
    }

    public BankAccount(string newCustomerName, double newBalance)
    {
        customerName = newCustomerName;
        balance = newBalance;

    }

}
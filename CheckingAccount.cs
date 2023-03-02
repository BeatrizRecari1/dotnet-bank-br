public class CheckingAccount : BankAccount
{
    public CheckingAccount(string newCustomerName, double newBalance) : base(newCustomerName, newBalance)
    {
        deposit(100); // All checking accounts created get $100 more in balance
    }
}
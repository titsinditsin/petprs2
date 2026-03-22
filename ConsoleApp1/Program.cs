using System;
class BankAccount
{
    private decimal balance;
    private string name;
    public string Name {  get { return name; } }
    public decimal Balance { get { return balance; } }
    public decimal Deposit(decimal amount)
    {
        if (amount < 0)
            return -1;
        else
        { 
            balance += amount;
            return amount;
        }
        
    }
    public decimal Withdraw(decimal amount)
    {
        if (amount > balance)
            return -1;
        else
        {
            balance -= amount;
            return amount;
        }
    }
}
public interface IPaymentProcessor
{
    void ProcessPayment(double amount);
}
public class PayPal : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Оплачено через PayPal: " + amount);
    }
}
class Shop
    {

    }


namespace pro100user.task3;

public class Investor : Client
{
    private string surname;
    private double amount;
    private double procent;
    private DateTime createdAt;

    public Investor()
    {
    }

    public Investor(string surname, double amount, double procent)
    {
        this.surname = surname;
        this.amount = amount;
        this.procent = procent;
        createdAt = DateTime.Now;
    }

    public void Print()
    {
        Console.WriteLine($"Investor {surname}, amount - {amount}, procent - {procent}, created at {createdAt}");
    }
    
    public void AddAmount(double amount)
    {
        this.amount += amount;
        createdAt = DateTime.Now;
    }
    
    public void MinusAmount(double amount)
    {
        this.amount -= amount;
    }
}
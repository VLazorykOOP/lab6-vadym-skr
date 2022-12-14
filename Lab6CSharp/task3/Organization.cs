namespace pro100user.task3;

public class Organization : Client
{
    private string name;
    private string number;
    private double amount;
    private DateTime createdAt;

    public Organization() { }

    public Organization(string name, string number, double amount)
    {
        this.name = name;
        this.number = number;
        this.amount = amount;
        createdAt = DateTime.Now;
    }

    public void Print()
    {
        Console.WriteLine($"Organization {name}, balance number - {number}, balnce amount - {amount}, created at {createdAt}");
    }
    
    public void AddAmount(double amount)
    {
        this.amount += amount;
    }
    
    public void MinusAmount(double amount)
    {
        this.amount -= amount;
    }
}
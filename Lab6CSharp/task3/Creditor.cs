namespace pro100user.task3;

public class Creditor : Client
{
    private string surname;
    private double amount;
    private double procent;
    private double dept;
    private DateTime createdAt;

    public Creditor()
    {
    }

    public Creditor(string surname, double amount, double procent, double dept)
    {
        this.surname = surname;
        this.amount = amount;
        this.procent = procent;
        this.dept = dept;
        createdAt = DateTime.Now;
    }

    public void Print()
    {
        Console.WriteLine($"Creditor {surname}, amount - {amount}, procent - {procent}, dept - {dept}, created at {createdAt}");
    }

    public void OpenCredit(double amount)
    {
        this.amount += amount;
        dept += amount + (amount * procent)/100;
        createdAt = DateTime.Now;
    }
    
    public void CloseCredit(double amount)
    {
        this.amount -= amount;
        dept -= amount;
    }
}
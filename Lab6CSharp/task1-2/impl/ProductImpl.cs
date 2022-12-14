namespace pro100user.task2;
//Виріб
public class ProductImpl : Product
{
    protected string name;
    
    public ProductImpl()
    {
        name = "product";
        Console.WriteLine("Constructor \"ProductImpl\"");
    }
    
    public ProductImpl(string name)
    {
        this.name = name;
        Console.WriteLine("Constructor \"ProductImpl\"");
    }

    ~ProductImpl()
    {
        Console.WriteLine("Destructor \"ProductImpl\"");
    }

    public virtual void Show()
    {
        Console.WriteLine("It's " + name);
    }
}
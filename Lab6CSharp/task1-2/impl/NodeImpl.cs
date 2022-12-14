namespace pro100user.task2;

//Вузол
public class NodeImpl : ProductImpl
{
    private int amount;
    
    public NodeImpl()
    {
        amount = 5;
        Console.WriteLine("Constructor \"NodeImpl\"");
    }
    
    public NodeImpl(int amount) : base("node")
    {
        this.amount = amount;
        Console.WriteLine("Constructor \"NodeImpl\"");
    }
    
    public NodeImpl(string name, int amount) : base(name)
    {
        this.amount = amount;
        Console.WriteLine("Constructor \"NodeImpl\"");
    }
    
    ~NodeImpl()
    {
        Console.WriteLine("Destructor \"NodeImpl\"");
    }
    
    public override void Show()
    {
        Console.WriteLine("It's " + name + ", amount = " + amount);
    }
}
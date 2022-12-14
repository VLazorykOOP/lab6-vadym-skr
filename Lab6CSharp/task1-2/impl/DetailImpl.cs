namespace pro100user.task2;

//Деталь
public class DetailImpl : ProductImpl
{
    private int weight;

    public DetailImpl()
    {
        weight = 10;
        Console.WriteLine("Constructor \"Detail\"");
    }
    
    public DetailImpl(int weight) : base("detail")
    {
        this.weight = weight;
        Console.WriteLine("Constructor \"Detail\"");
    }
    
    public DetailImpl(string name, int weight) : base(name)
    {
        this.weight = weight;
        Console.WriteLine("Constructor \"Detail\"");
    }
    
    ~DetailImpl()
    {
        Console.WriteLine("Destructor \"Detail\"");
    }
    
    public override void Show()
    {
        Console.WriteLine("It's " + name + ", weight = " + weight);
    }
}
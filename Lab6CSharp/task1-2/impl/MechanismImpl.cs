namespace pro100user.task2;

//Механізм
public class MechanismImpl : ProductImpl
{
    private int time;
    
    public MechanismImpl()
    {
        time = 30;
        Console.WriteLine("Constructor \"MechanismImpl\"");
    }
    
    public MechanismImpl(int time) : base("mechanism")
    {
        this.time = time;
        Console.WriteLine("Constructor \"MechanismImpl\"");
    }
    
    public MechanismImpl(string name, int time) : base(name)
    {
        this.time = time;
        Console.WriteLine("Constructor \"MechanismImpl\"");
    }
    
    ~MechanismImpl()
    {
        Console.WriteLine("Destructor \"MechanismImpl\"");
    }
    
    public override void Show()
    {
        Console.WriteLine("It's " + name + ", time of work = " + time);
    }
}
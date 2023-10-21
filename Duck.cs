abstract class Duck {

    public IFlyBehavior flyBehavior{get;set;}
    public IQuackBehavior quackBehavior {get; set;}
    public string name{get; set;}

     public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, string name)
    {
        this.flyBehavior = flyBehavior;
        this.quackBehavior = quackBehavior;
        this.name = name;
    }
    
    public void display(){
        Console.WriteLine($"{name}");
    }
    public void performQuack(){
        quackBehavior.quack();
    }
    
    public void performFly(){
        flyBehavior.fly();
    }
}
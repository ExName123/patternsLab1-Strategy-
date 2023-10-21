class Program{
    static void Main() {
    Console.WriteLine("Симуляция уток:");
    Console.WriteLine();
    SaxonDuck saxonDuck = new SaxonDuck(new FlyWithWings(), new QuackRare(), "Саксонская утка"); 
    saxonDuck.display();
    saxonDuck.performQuack();
    saxonDuck.performFly();
    
    Console.WriteLine();
    RubberDuck rubberDuck = new RubberDuck(new FlyNoWay(), new MuteQuack(), "Резиновая утка"); 
    rubberDuck.display();
    rubberDuck.performQuack();
    rubberDuck.performFly();
    
    Console.WriteLine();
    BaitDuck baitDuck = new BaitDuck(new FlyNoWay(), new Quack(), "Утка-приманка"); 
    baitDuck.display();
    baitDuck.performQuack();
    baitDuck.performFly();
    baitDuck.flyBehavior = new FlyRadio();
    baitDuck.performFly();
    
    Console.WriteLine();
    RedHeadedDuck redHeadedDuck = new RedHeadedDuck(new FlyWithWings(), new MuteQuack(), "Красноголовая утка"); 
    redHeadedDuck.display();
    redHeadedDuck.performQuack();
    redHeadedDuck.quackBehavior = new Squeak();
    redHeadedDuck.performQuack();
    redHeadedDuck.performFly();

  }
}

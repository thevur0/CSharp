namespace CSharp
{
    public partial class MainClass
    {
        Animal[] anims = new Animal[] 
        { new Cat(), new Fish(), new Bird() };
        foreach (var item in anims)
        {
            item.Print();   
        }
    }
}
namespace Abstract
{
    abstract class Animal
    {
        public abstract void Print();
    }
    class Cat : Animal
    {
        public override void Print() 
        { Console.WriteLine("猫"); }
    }
    class Fish : Animal
    {
        public override void Print() 
        { Console.WriteLine("鱼"); }
    }
    class Bird : Animal
    {
        public override void Print() 
        { Console.WriteLine("鸟"); }
    }
}
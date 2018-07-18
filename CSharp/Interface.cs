namespace CSharp
{
    public partial class MainClass
    {
        static void InterfaceTest()
        {
            Animal[] anims = new Animal[]{ new Cat(), new Fish(), new Bird() };
            foreach(var item in anims)
            {
                //让会走路的走路
                IWalk iWalk = item as IWalk;
                if (iWalk!=null)
                {
                    item.Print();
                    iWalk.Walk();
                }
            }
        }
        
    }
}

namespace Interface
{
    interface IWalk
    {
        void Walk();
    }
    interface IFly
    {
        void Fly();
    }
    interface ISwim
    {
        void Swim();
    }
    abstract class Animal
    {
        public abstract void Print();
    }

    class Cat : Animal, IWalk
    {
        public override void Print() { Console.WriteLine("猫"); }
        public void Walk() { Console.WriteLine("四条腿走路"); }
    }
    class Fish : Animal, ISwim
    {
        public override void Print() { Console.WriteLine("鱼"); }
        public void Swim() { Console.WriteLine("游泳"); }
    }
    class Bird : Animal,IFly,IWalk
    {
        public override void Print() { Console.WriteLine("鸟"); }
        public void Fly() { Console.WriteLine("飞翔"); }
        public void Walk() { Console.WriteLine("两条腿走路"); }
    }
}
namespace CSharp
{
    public partial class MainClass
    {
        static void VirtualFunTest()
        {
            Human man = new Human();
            man.Print(); //显示人类
            Animal animal = man;
            animal.Print();//显示人类

            Animal[] anims = new Animal[] { new Cat(), new Fish(), new Bird() };
            foreach (var anim in anims)
            {
                anim.Print();
            }
        }
    }
}
namespace VirtualFun
{
    class Animal
    {
        public virtual void Print() { Console.WriteLine("动物类"); }
    }
    class Human : Animal
    {
        public override void Print() { Console.WriteLine("人类"); }
    }
    class Cat : Animal
    {
        public override void Print() { Console.WriteLine("猫"); }
    }
    class Fish : Animal
    {
        public override void Print() { Console.WriteLine("鱼"); }
    }
    class Bird : Animal
    {
        public override void Print() { Console.WriteLine("鸟"); }
    }
}
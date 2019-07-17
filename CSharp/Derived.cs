using System;
using Derived;
namespace CSharp
{
    public class Derived
    {
        static void DerivedTest()
        {
            Human man = new Human();
            man.ReName("人类"); //调用派生类函数，man.Name = “人类”;不能调用
            Console.WriteLine(man.Name); //调用基类函数

        }
    }
}
namespace Derived
{
    class Animal
    {
        public string Name { get; protected set; }
    }
    class Human : Animal
    { 
        public void ReName(string sName)
        {
            Name = sName;
        }
    }


    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("BaseClass.Print");
        }
    }

    class DerivedClass: BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("DerivedClass.Print");
        }
    }

}
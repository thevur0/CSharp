using HideMember;
using System;
namespace CSharp
{
    public partial class MainClass
    {
        static void HideMemberTest()
        {
            Human man = new Human();
            man.Print(); //显示人类
            Animal animal = man;
            animal.Print();//显示动物类
        }
    }
}
namespace HideMember
{
    class Animal
    {
        public void Print(){  Console.WriteLine("动物类");}
    }
    class Human : Animal
    {
        public new void Print() { Console.WriteLine("人类"); }
    }
}
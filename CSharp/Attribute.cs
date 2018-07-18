using Attribute;
using System;
namespace CSharp
{
    public partial class MainClass
    {
        static void AttributeTest()
        {
            Animal[] animals = {new Cat(),new Dog()};
            foreach(var animal in animals)
            {
                Console.WriteLine(animal.Kind);
            }
        }
    }
}
namespace Attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    class AnimalKindAttr: System.Attribute
    {
        public AnimalKindAttr(string sKind)
        {
            Name = sKind;
        }
        public string Name{get;protected set;}
    }

    public abstract class Animal
    {
        public Animal()
        {
            object[] attrs = GetType().GetCustomAttributes(true);
            foreach(var attr in attrs )
            {
                if(attr is AnimalKindAttr)
                {
                    var kindAttr = attr as AnimalKindAttr;
                    if(kindAttr!=null)
                        Kind = kindAttr.Name;

                }
            }
        }
        public string Kind{get;protected set;}
    }
    [AnimalKindAttr("猫")]
    public class Cat:Animal
    {

    }
    [AnimalKindAttr("狗")]
    public class Dog:Animal
    {

    }
}
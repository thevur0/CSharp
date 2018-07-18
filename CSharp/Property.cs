using System;
using Property;
namespace CSharp
{
    public partial class MainClass
    {
        static void PropertyTest()
        {
            Animal animal = new Animal();
            animal.Name = "动物"; 
            Console.WriteLine(animal.Name);
        }
    }
}
namespace Property
{
    class Animal
    {
        // string m_sName; 
        // public string Name
        // {
        //     get
        //     {
        //         return m_sName;
        //     }
        //     set
        //     {
        //         m_sName = value;
        //     }
        // }
        public string Name { get; set; }
    }

}
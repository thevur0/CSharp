using System;
using Construction;

namespace CSharp
{
    public partial class MainClass
    {
        static void Construction()
        {
            Animal animal1 = new Animal("动物1");
            Console.WriteLine("名字：{0}",animal1.GetName());
            Animal animal2 = new Animal("动物2");
            Console.WriteLine("名字：{0}",animal2.GetName());
        }
    }
}

namespace Construction
{
    class Animal
    {
        static Animal()
        {
            Console.WriteLine("static Animal");
        }
        public Animal() { 
            Console.WriteLine("Animal");
        }    //构造函数  可省略
        public Animal(string sName) //构造函数
        {
            m_sName = sName;
        }
        ~Animal() { }            //析构函数 可省略
        string m_sName;    //成员变量
        public string GetName()    //成员函数
        {
            return m_sName;
        }
    }
}



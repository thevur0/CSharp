using System;
using Exception;
namespace CSharp
{
    public partial class MainClass
    {
        static void ExceptionTest()
        {
            Dog dog = new Dog();
            try
            {
                dog.Run();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                dog.Sleep();
            }
        }
    }
}
namespace Exception
{
    class MyException : System.Exception
    {
        public MyException(string str):base(str)
        {

        }
    }
    class Dog
    {
        public int Legs { get;private set; } 
        public void Run()
        {
            
            if (Legs != 4)
            {
                throw new MyException("狗应该有四条腿");
            }
            Console.WriteLine("跑起来了");
        }
        public void Sleep()
        {
            Console.WriteLine("睡觉");
        }
    }

}
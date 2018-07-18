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
            catch (Exception e)
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
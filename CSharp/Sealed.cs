namespace CSharp
{
    public partial class MainClass
    {
        static void SealedTest()
        {

        }
    }
}
namespace Sealed
{
    class Animal
    {

    }

    /// <summary>
    /// 类定义前面放置关键字 sealed，可以将类声明为密封类。当一个类被声明为 sealed 时，它不能被继承。抽象类不能被声明为 sealed
    /// </summary>
    sealed class Fish : Animal
    {
        public override void Print() { Console.WriteLine("鱼"); }
    }

    class Bird : Animal
    {
        /// <summary>
        /// 重写的函数前面放置关键字sealed，该函数不会再被重写，与override一起用
        /// </summary>
        sealed public override void Print() { Console.WriteLine("鸟"); }
    }

}
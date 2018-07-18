using System;
namespace CSharp
{
    public partial class MainClass
    {
        
        static void DelegateTest()
        {
            //创建一个委托对象
            Function f = new Function(Square);
            //利用f携带的“Square”方法，所以可以用f进行间接调用Square
            //也可以写f(5)，这是对f.Invoke(5)的语法简化
            double result = f.Invoke(5);
            System.Console.WriteLine(result);//25

            var fun = new Func<double,double>(Square);
            var act = new Action<double>(Print);//16

            double value = fun.Invoke(4);
            act.Invoke(value);
        }
        //声明一个委托
        delegate double Function(double x);
        static double Square(double x)
        {
            return x * x;
        }
        static void Print(double value)
        {
            System.Console.WriteLine(value);
        }

    }
}
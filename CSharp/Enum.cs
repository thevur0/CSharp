using System;
namespace CSharp
{
    public partial class MainClass
    {
        //:long表括示基础类型是long
        //如果不写则默认为int
        enum Alignment : long
        {
            //=也可不写，默认则是以0开始，依次加1
            Left = -1,
            Center = 0,
            Right = 1
        }

        static void EnumTest()
        {
            //初始化一个枚举变量
            Alignment alignment = Alignment.Left;
            //输出：Left
            Console.WriteLine(alignment);
            //输出：-1
            Console.WriteLine((long)alignment);
            //获得基础类型
            Type underlyingType = Enum.GetUnderlyingType(typeof(Alignment));
            //输出：System.Int64
            //解释：[long关键字映射的类型为System.Int64]
            Console.WriteLine(underlyingType.FullName);
        }    
    }
}
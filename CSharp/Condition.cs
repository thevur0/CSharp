using System;
namespace CSharp
{
    public partial class MainClass
    {
        static void ConditionTest()
        {
            bool isTrue = true;

            if (isTrue)
            {
                Console.WriteLine("true");
            }

            if (isTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            if (!isTrue)
            {
                Console.WriteLine("true");
            }
            else if(true)
            {
                Console.WriteLine("false");
            }


            if (true) //只有一行可省略代码段

                Console.WriteLine("true");

            int i = 0;
            if(i > 0)i = 1;else i = 0; //赋值时条件表达式代替if else
            i = i > 0 ? 1 :0;

            object objA = default(object), objB = default(object);
            if(objA != null && objA.Equals(objB))
            {
                Console.WriteLine(objA.ToString());
            }

            object obj = objA ?? objB;

            objA?.ToString();

            DateTime now = DateTime.Now;
            DayOfWeek week = now.DayOfWeek;
            switch (week)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("休息");

                    break;
                default:
                    Console.WriteLine("上班");
                    break;
            }

            goto goto1;
            Console.WriteLine("jump");
        goto1:
            Console.WriteLine("abc");
        }
    }
}
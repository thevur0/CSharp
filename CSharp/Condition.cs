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
                //执行
                System.Console.WriteLine("true");
            }
            if (!isTrue)
            {
                //不执行
                System.Console.WriteLine("true");
            }
            else if(true)
            {
                //执行
                System.Console.WriteLine("false");
            }

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
        }
    }
}
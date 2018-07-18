using System;
namespace CSharp
{
    public partial class MainClass
    {
        static void Loop()
        {
            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine(i);
            }

            int[] array = new int[] { 1, 3, 5, 7, 9 };
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            int iIndex = 0;
            while (iIndex < 10)
            {
                System.Console.WriteLine(iIndex);
                iIndex++;
            }

            int iIndex1 = 0;
            do
            {
                System.Console.WriteLine(iIndex1);
                iIndex1++;
                //这个while条件后面是有分号的,是必须的
            } while (iIndex1 < 10);

            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    continue;
                }
                if (i==8)
                {
                    break;
                }
                Console.Write(i);
            }
            //输出结果：0123467
        }
    }
}
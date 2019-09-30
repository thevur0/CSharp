using System;
namespace CSharp
{
    public partial class MainClass
    {
        static void ArrayTest()
        {
            //元素个数为3的int类型数组
            int[] ages = new int[3];
            Console.WriteLine(ages.Length);
            //3 X 3的多维数组
            int[,] array1 = new int[3, 5];
            for (int i = 0; i < array1.Rank; i++)
                Console.WriteLine("Length:{0}", array1.GetLength(i));
            //交错数组
            int[][] array2 = new int[2][];
            array2[0] = new int[2] { 3, 4 };
            array2[1] = new int[3];
            //输出：4
            Console.WriteLine(array2[0][1]);

            for (int i = 0; i < array2.Rank; i++)
                Console.WriteLine("Length:{0}", array2.GetLength(i));

            bool[][][] array3 = new bool[2][][];
            array3[0] = new bool[2][];
            array3[0][0] = new bool[] { true, true };
            array3[0][1] = new bool[] { true, true, true };
            array3[1] = new bool[2][] { new bool[] { false, false }, new bool[] { false, false, false } };
            foreach (var item1 in array3)
            {
                foreach (var item2 in item1)
                {
                    Console.WriteLine();
                    foreach (var item3 in item2)
                    {
                        Console.Write($"{item3} ");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //结构体数组
            var structArray = new Point[] { new Point(1,1), new Point(2, 2), new Point(3, 3)};
            foreach (var sa in structArray)
            {
                Console.WriteLine(sa);
            }
        }

        struct Point
        {
            int x;
            int y;
            public Point(int value1,int value2)
            {
                x = value1;
                y = value2;
            }

            public override string ToString()
            {
                return $"x:{x} y:{y}";
            }
        }
    }
    
}
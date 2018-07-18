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
            Console.WriteLine("Length:{0},{1}" ,array1.GetLength(0),array1.GetLength(1));
            //交错数组
            int[][] array2 = new int[2][];
            array2[0] = new int[2] { 3, 4 };
            array2[1] = new int[3];
            //输出：4
            Console.WriteLine(array2[0][1]);
            Console.WriteLine("Length:{0}" ,array2.GetLength(0));

        }
    }
    
}
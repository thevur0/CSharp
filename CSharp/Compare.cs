using System;
using System.Collections.Generic;
using Compare;
namespace CSharp
{
    public partial class MainClass
    {
        static int Compare(int x, int y)
        {
            return y - x;//从大到小
        }


        static void CompareTest()
        {
            List<int> list = new List<int>(new int[] { 5, 1, 4, 7, 3 });
            list.Sort(new IntCompare()); //利用IComparer接口
            Console.Write("Sort:");
            foreach (var i in list)
                Console.Write("{0} ",i);

            Console.WriteLine();
            list.Sort(Compare); //利用int Compare(int,int)函数
            Console.Write("Sort:");
            foreach (var i in list)
                Console.Write("{0} ", i);
        }
    }
}

namespace Compare
{
    class IntCompare : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;//从小到大
        }
    }

}
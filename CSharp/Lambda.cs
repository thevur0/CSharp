using System;
using System.Collections.Generic;

namespace CSharp
{
    public partial class MainClass
    {
        static void LambdaTest()
        {
            List<int> list = new List<int>(new int[] { 5, 1, 4, 7, 3 });
            list.Sort((x, y) => { return x - y; }); 
            Console.Write("从小到大:");
            foreach (var i in list)
                Console.Write("{0} ", i);
        }
    }
}
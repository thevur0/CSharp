using System;
using System.Collections.Generic;
namespace CSharp
{
    public partial class MainClass
    {

        static void ReturnTest()
        {
            var v1 = ReturnInt();
            var v2 = ReturnString();
            var v3 = ReturnList();
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
        }   

        static int ReturnInt()
        {
            return 10;
        }
        static string ReturnString()
        {
            return "string";
        }
        static List<int> ReturnList()
        {
            return new List<int>(){1,2,3,4};
        }
    }
}
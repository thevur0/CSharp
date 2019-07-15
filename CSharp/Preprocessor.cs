#define PRE_TEST
using System;

namespace CSharp
{

    public partial class MainClass
    {
        static void PreprocessTest()
        {
#if PRE_TEST
    Console.WriteLine("define PRE_TEST");
#else
    Console.WriteLine("undefine PRE_TEST");
#endif
        }
    }
}
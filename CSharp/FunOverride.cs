using System;
using FunOverride;
namespace CSharp
{
    public partial class MainClass
    {
        static void FunOverrideTest()
        {
            int a = 1, b = 2;
            Tool.Swap(ref a, ref b);
            string strA = "a", strB = "b";
            Tool.Swap(ref strA, ref strB);
        }
    }
}

namespace FunOverride
{
    class Tool
    {
        public static void Swap(ref int a, ref int b)
        {
            int iTemp = a;
            a = b;
            b = iTemp;
        }
        public static void Swap(ref string a, ref string b)
        {
            string sTemp = a;
            a = b;
            b = sTemp;
        }
    }

}
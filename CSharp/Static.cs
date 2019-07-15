using System;
using Static;

namespace CSharp
{
    using static Tool;
    public partial class MainClass
    {
        static void StaticTest()
        {
            float r = 2.4f;
            float fArea = CalcArea(r);
        }
    }
    //static void StaticTest()
    //{
    //    float r = 2.4f;
    //    float fArea = Tool.CalcArea(r);
    //}

}

namespace Static
{
    class Tool
    {
        static float PI = 3.1415926f;
        public static float CalcArea(float r)
        {
            return PI * r * r;
        }
    }
}
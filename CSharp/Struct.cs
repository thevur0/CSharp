using System;
namespace CSharp
{
    partial class MainClass
    {
        /// <summary>
        /// 结构
        /// </summary>
        static void StructTest()
        {
            Point pt = new Point(100,40);
            Console.WriteLine(pt.ToString());
        }
    }
    public struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format("X:{0} Y:{1}",x,y);
        }
    }
}
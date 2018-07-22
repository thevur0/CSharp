using System;
using OperatorOverride;
namespace CSharp
{
    public partial class MainClass
    {
        static void OperatorOverrideTest()
        {
            Rect a = new Rect(10, 20);
            Rect b = new Rect(20, 10);
            if (a == b)
            {
                Console.WriteLine("a==b");
            }
            else
            {
                Console.WriteLine("a!=b");
            }
        }
    }
}
namespace OperatorOverride
{
    class Rect
    {
        public Rect(int iWidth, int iHeight) 
        {
            Width = iWidth;
            Height = iHeight;
        }
        public float Width { get;private set; }
        public float Height { get; private set; }
        public static bool operator ==(Rect a, Rect b)
        {
            if (a.Width == b.Width && a.Height == b.Height)
            {
                return true;
            }
            else if (a.Width == b.Height && a.Height == b.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Rect a, Rect b)
        {
            if (a.Width != b.Width || a.Height == b.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
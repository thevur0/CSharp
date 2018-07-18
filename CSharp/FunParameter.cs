using System;
namespace CSharp
{
    public partial class MainClass
    {
        static void FunParameterTest()
        {
            int a = 1, b = 2;
            Swap(a, b);
            Console.WriteLine("a:{0},b:{1}",a,b);   //a:1,b:2
            Swap(ref a,ref b);
            Console.WriteLine("a:{0},b:{1}", a, b); //a:2,b:1

            int iX, iY;
            if (GetXY(out iX, out iY))
            {
                //X:100,Y:50
                Console.WriteLine("X:{0},Y:{1}",iX,iY);
            }
        }

        static void Swap(int a, int b)
        {
            int iTemp = a;
            a = b;
            b = iTemp;
        }
         
        static void Swap(ref int a,ref int b)
        {
            int iTemp = a;
            a = b;
            b = iTemp;
        }

        static bool GetXY(out int iX, out int iY)
        {
            iX = 100;
            iY = 50;
            return true;
        }

    }
}
namespace FunParameter
{

}
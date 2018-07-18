using System;
using System.Collections;
namespace CSharp
{
    public partial class MainClass
    {
        static void CollectionTest()
        {

            ArrayList arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add(2);
            arraylist.Add("a");
            arraylist.Add("b");
            foreach (object obj in arraylist)
            {
                Console.WriteLine(obj);
            }

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push("a");
            stack.Push("b");
            foreach (object obj in stack)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
namespace Collection
{

}
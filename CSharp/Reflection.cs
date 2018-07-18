using System;
using Reflection;
using System.Reflection;

namespace CSharp
{
    public partial class MainClass
    {
        static void ReflectionTest()
        {
            Test test = new Test();
            Type type = typeof(Test);
            MethodInfo methodInfo = type.GetMethod("NonPublic", BindingFlags.NonPublic | BindingFlags.Instance);
            if (methodInfo != null)
            {
                methodInfo.Invoke(test, null);
            }
        }
    }
}

namespace Reflection
{
    class Test
    {
        private void NonPublic() 
        { 
            Console.WriteLine("私有方法"); 
        }
    }
}

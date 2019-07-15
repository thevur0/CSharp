
namespace CSharp
{
    
    using System;
    using static System.Console;
    partial class MainClass
    {
        static void GCTest()
        {
            GC.Collect();
            int maxGeneration = GC.MaxGeneration;
            WriteLine($"MaxGeneration:{maxGeneration}");
        }
    }
    
}
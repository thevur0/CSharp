
namespace CSharp
{

    using static System.IO.Path;

    using Water = NameSpaceA.Water;
    

    public partial class MainClass
    {
        /// <summary>
        /// 命名空间
        /// </summary>
        /// 

        
        static void NameSpaceTest()
        {
            //使用命名空间中的类
            //可以using namespace System.Collections;
            System.Collections.ArrayList list = new System.Collections.ArrayList();

            //使用using static
            string fileNmme = GetFileName(@"C:/newfile.txt");

            Water water = new Water();
            water.Drunk();
        }
    }
    //命名空间嵌套
    namespace NameSpaceNesting
    {
    }


    namespace NameSpaceA
    {
        class Water
        {
            public void Drunk()
            {
            }
        }
    }

    namespace NameSpaceB
    {
        class Water
        {
            public void Wash()
            {
            }
        }
    }
}
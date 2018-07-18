namespace CSharp
{
    public partial class MainClass 
    {
        static void GenericTest()
        {
            int a = 1, b = 2;
            Tool.Swap<int>(ref a, ref b);
            Console.WriteLine("a:{0},b:{1}", a, b);
            string strA = "a", strB = "b";
            Tool.Swap<string>(ref strA, ref strB);
            Console.WriteLine("strA:{0},strB:{1}", strA, strB);

            SceneManager.Instance.Init();
            RoleManager.Instance.Init();


            List<int> list1 = new List<int>();
            list1.Add(5); //添加5

            int[] array = new int[] { 1, 4, 7, 3 };
            List<int> list2 = new List<int>(array);
            list1.AddRange(list2); //添加list 1,4,7,3

            foreach (int i in list1)
                Console.WriteLine("{0}", i);

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic[0] = "输球"; //支持索引器
            dic.Add(1, "平局");
            dic.Add(3,"赢球");
            foreach (var item in dic)
                Console.WriteLine("{0}表示{1}",item.Key,item.Value);
            string sStrOut;
            if (dic.TryGetValue(1,out sStrOut)) //查找返回true
            {
                Console.WriteLine("查找1是{0}", sStrOut);
            }
        }
    }
}

namespace Generic
{
    class Tool
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    class Singleton<T> where T : class,new()
    {
        static T m_Mgr = null;
        public static T Instance
        {
            get 
            {
                if(m_Mgr == null)
                    m_Mgr = new T();
                return m_Mgr;
            }
        }
    }

    class SceneManager : Singleton<SceneManager>
    {
        public void Init() { Console.WriteLine("SceneMgr Init."); }
    }
    class RoleManager : Singleton<RoleManager>
    {
        public void Init() { Console.WriteLine("RoleMgr Init."); }
    }
}
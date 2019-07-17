using System;
using System.Collections.Generic;
using Generic;
using Derived;
namespace CSharp
{
    public partial class MainClass 
    {
        static void GenericTest()
        {
            //泛型函数
            int a = 1, b = 2;
            Tool.Swap<int>(ref a, ref b);
            Console.WriteLine($"a:{a},b:{b}");
            string strA = "a", strB = "b";
            Tool.Swap<string>(ref strA, ref strB);
            Console.WriteLine($"strA:{strA},strB:{strB}");

            //单例使用
            SceneManager.Instance.Init();
            RoleManager.Instance.Init();

            //泛型类
            List<int> listA = new List<int>();
            listA.Add(5); //添加5
            int[] array = new int[] { 1, 4, 7, 3 };
            List<int> listB = new List<int>(array);
            listA.AddRange(listB); //添加list 1,4,7,3
            foreach (int i in listA)
                Console.WriteLine($"{i} ");
            Console.WriteLine();

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic[0] = "输球"; //支持索引器
            dic.Add(1, "平局");
            dic.Add(3,"赢球");
            foreach (var item in dic)
                Console.WriteLine($"{item.Key}表示{item.Value}");
            string sStrOut;
            if (dic.TryGetValue(1,out sStrOut)) //查找返回true
            {
                Console.WriteLine($"查找1是{sStrOut}");
            }

            //系统委托Action、Func、Predicate
            Action<int,int> action = new Action<int,int>(Tool.Print);
			action.Invoke(5,2);

			Func<int,int,int> func = delegate (int arg1,int arg2){ return arg1 + arg2; } ;
			Console.WriteLine(func.Invoke(1 , 2));
            
			List<int> list = new List<int>(new int[] { 5, 1, 4, 7, 3 });
			Predicate<int> predicate = (arg1) => { return arg1 >= 4; };
			var find = list.FindAll(predicate);
			find.ForEach((item) => { Console.Write($"{item} "); });

            var strlist = list.ConvertAll<string>((item) => {return (item*2).ToString(); });
            Console.WriteLine();
            strlist.ForEach((item) => { Console.Write($"{item} "); });
        }

        static void ContravariantAndCovariant()
        {
            IContravariant<BaseClass> iBaseClassA = new Contravariant<BaseClass>();
            iBaseClassA.Method(new DerivedClass());

            ICovariant<BaseClass> iBaseClassB = new Covariant<BaseClass>();
            iBaseClassB.Method().Print();
        }
    }
}

namespace Generic
{
    using DesignMode;
    class Tool
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static void Print(int a, int b)
        {
            Console.WriteLine("a:{0},b:{1}", a, b);
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


    //逆变
    interface IContravariant<in T> where T: BaseClass
    {
        void Method(T t);
    }
    //协变
    interface ICovariant<out T> where T: BaseClass
    {
        T Method();
    }

    class Contravariant<T> : IContravariant<T> where T : BaseClass
    {
        public void Method(T t)
        {
            t.Print();
        }
    }

    class Covariant<T> : ICovariant<T> where T : BaseClass
    {
        public T Method()
        {
            return default(T);
        }
    }
}
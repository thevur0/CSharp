using System;

namespace CSharp
{
    partial class MainClass
    {
        /// <summary>
        /// XML注释 
        /// </summary>
        static void NoteTest()
        {
            //单行注释

            /*
             多行注释
            */
            Console.WriteLine("测试注释");
        }

        

        /// <summary>
        /// 变量
        /// </summary>
        static void VariableTest()
        {
            //变量初始化
            int a1 = 100;
            int _a2 = 100;
            //使用@开头的关键字
            int @int = 10;
            //使用Unicode转义序列关键字
            string n\u0061me = "12345";
            Console.WriteLine(@int);
            Console.WriteLine(n\u0061me);

            //装箱操作
            object obj = a1;
            Console.WriteLine(obj);
            int iValue = (int)obj;
            //拆箱操作
            Console.WriteLine(iValue);

            //类型转换

            int i1 = 10;
            float f1 = (float)i1;  //整型转浮点型

            float f2 = 2.482f;
            int i2 = (int)f2;   //浮点型转整型

            int i3 = 35822;         
            string s1 = i3.ToString();  //整型转字符串

            string s2 = "532.2325";
            float f3 = float.Parse(s2);  //字符串转浮点型

            string s3 = "8848.13";
            float.TryParse(s3,out float f4);

            Console.WriteLine(f4);

        }
        

        const string m_IP = "127.0.0.1";
        readonly string m_Port;
        readonly float m_PI = 3.1415926f;
        //正确，readonly可定义任意数据类型
        readonly MainClass main;
        //错误，MainClass为自定义复杂类型，不能用const
        //const MainClass mian1 = new MainClass();
        MainClass()
        {   //readonly 可以在构造函数中初始化
            m_Port = "80";
            main = new MainClass();
        }
        static void ConstTest()
        {
            //readonly 不能在函数里声明
            //readonly float m_PI = 3.1415926f;
            const string IP = "127.0.0.1";
            Console.WriteLine(IP);
        }
    }
}
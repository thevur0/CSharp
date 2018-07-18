using System;
namespace CSharp
{
    public partial class MainClass
    {
        static void StringTest()
        {
            String name = "[小明";
            //合并字符串
            name = name + " 20岁";
            name = name + " 男生]";
            Console.WriteLine(name);//[小明 20岁 男生]    
            //替换空格为"-"
            name = name.Replace(' ', '-');
            Console.WriteLine(name);//[小明-20岁-男生]
            Console.WriteLine("[{0} {1}岁 {2}]","小明",20,"男生");

            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                //追加字符串
                stringBuilder.Append(i.ToString() + "|");
            }
            //输出：1|2|3|4|5.....999|
            Console.WriteLine(stringBuilder.ToString());
            stringBuilder.Clear();

        }
    }
}
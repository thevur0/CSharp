using System;
namespace CSharp
{
    public partial class MainClass
    {
        static void StringTest()
        {
            String name = "[小明";
            name = name + " 20岁";//合并字符串
            name += " 男生]";
            Console.WriteLine(name);//[小明 20岁 男生]    
            name = name.Replace(' ', '-');//替换空格为"-"
            Console.WriteLine(name);//[小明-20岁-男生]
            Console.WriteLine("{0} 格式化字符串",name);
            Console.WriteLine($"{name} C#6.0 字符串插值");

            Console.WriteLine();
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
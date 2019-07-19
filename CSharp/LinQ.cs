using System.Collections.Generic;
using System.Linq;
namespace CSharp
{
    using static System.Console;
    public partial class MainClass
    {
        static void LinqTest()
        {
            int[] array = { 1, 5, 6, 4, 8, 3, 2, 9 };
            //var whereRes = array.Where(item=>item>5);
            //WriteLine(ToString(whereRes));

            //var selectRes = array.Select((item=>item*2));
            //WriteLine(ToString(selectRes));

            //var countRes = array.Count(item => item > 5);
            //WriteLine(countRes);

            var orderbyRes = array.OrderBy(item => item);
            WriteLine(ToString(orderbyRes));

            var orderbyDescendingRes = array.OrderByDescending(item => item);
            WriteLine(ToString(orderbyDescendingRes));


            var people =  new { Name = "aaa", Age = 10 };

            var peoples = new []{ new { Name = "bbb", Age = 10 }, new { Name = "aaa", Age = 1 }, new { Name = "ccc", Age = 50 }, new { Name = "eee", Age = 30 }, new { Name = "ddd", Age = 100 } };

            var selects = from p in peoples where p.Age > 10 select p.Name;
            WriteLine(ToString(selects));

            var selectman = from p in peoples where p.Age > 10 select new { p.Name, Sex = "m" };
            WriteLine(ToString(selectman));

            var selectman1 = from p in peoples let p1 = new { p.Name, p.Age,Sex = "m" } orderby p.Age select p1;
            WriteLine(ToString(selectman1));

            var select20s = from p in peoples group p by p.Age>20;
            foreach(var select20 in select20s)
            {
                WriteLine(ToString(select20));
            }

            var select30s = from p in peoples group p by p.Age > 30 into groups select new { Less30 = groups.Key, Item = groups};
            foreach (var select30 in select30s)
            {
                if(select30.Less30)
                    WriteLine(ToString(select30.Item));
            }

            var grades = new []{ "一", "二", "三", "四", "五" };
            var classes = new[] { "一", "二", "三" };
            var gradeclass = from g in grades from c in classes select new { g, c };
            WriteLine(ToString(gradeclass.Select(item=>$"{item.g}年{item.c}班")));
        }

        

        public static string ToString<T>(IEnumerable<T> items)
        {
            string s = string.Empty;
            foreach (var item in items)
            {
                s += item.ToString();
                s += " ";
            }
            return s;
        }
    }

    
}
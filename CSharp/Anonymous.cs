namespace CSharp
{
    public partial class MainClass
    {
        static void AnonymousTest()
        {
            List<int> list = new List<int>(new int[] { 5, 1, 4, 7, 3 });
            list.Sort(delegate(int x,int y){return x-y;});
            Console.Write("从小到大:");
            foreach (var item in list)
                Console.Write("{0} ", item);
        }
    }
}
namespace Anonymous
{

}
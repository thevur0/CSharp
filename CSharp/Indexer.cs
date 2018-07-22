using System;
using Indexer;
namespace CSharp
{
    public partial class MainClass
    {
        static void IndexerTest()
        {
            WeekWorkState workstate = new WeekWorkState();
            workstate[DayOfWeek.Saturday] = "休息";
            workstate[DayOfWeek.Sunday] = "休息";
            foreach (DayOfWeek eDayofWeek in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine("{0}{1}", eDayofWeek.ToString(), workstate[eDayofWeek]);
            }
        }
    }
}

namespace Indexer
{
    class WeekWorkState
    {
        const string sDefault = "上班";
        string[] sArray = new string[7];
        public string this[DayOfWeek eDayOfWeek]
        {
            get
            {
                string sState = sArray[(int)eDayOfWeek];
                return string.IsNullOrEmpty(sState) ? sDefault : sState;
            }
            set { sArray[(int)eDayOfWeek] = value; }
        }
    }
}
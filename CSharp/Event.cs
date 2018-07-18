namespace CSharp
{
    public partial class MainClass
    {
        static void EventTest()
        {
            RedLight redlight = new RedLight();
            Car car = new Car();
            Human ming = new Human();
            redlight.RedLightOnEvent += car.Stop;
            redlight.RedLightOnEvent += ming.Walk;
            redlight.On(EventArgs.Empty);
        }
    }
}

namespace Event
{
    delegate void RedLightOnEventHander(object sender,EventArgs e);
    class RedLight
    {
        public event RedLightOnEventHander RedLightOnEvent;
        public void On(EventArgs e)
        {
            Console.WriteLine("红灯亮");
            if (RedLightOnEvent != null)
            {
                RedLightOnEvent.Invoke(this, e);
            }
        }
    }

    class Human
    {
        public void Walk(object sender, EventArgs e)
        {
            Console.WriteLine("人走路");
        }
    }

    class Car
    {
        public void Stop(object sender, EventArgs e)
        {
            Console.WriteLine("车停下来");
        }
    }
}
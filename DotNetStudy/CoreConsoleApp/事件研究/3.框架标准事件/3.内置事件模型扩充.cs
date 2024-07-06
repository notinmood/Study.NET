/**
 * @file   : _3.cs
 * @date   : 2024/7/6 10:40:23
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.事件研究._3.框架标准事件
{
    internal class MyEventArgs : EventArgs
    {
        private readonly string _name;
        private readonly string _value;

        public MyEventArgs(string name, string value)
        {
            this._name = name;
            this._value = value;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Value
        {
            get { return _value; }
        }
    }

    internal class BetterPubliser
    {


        public event EventHandler<MyEventArgs> myEvent;
        public void Publish()
        {
            myEvent?.Invoke(this, new MyEventArgs("city", "tengzhou"));
        }
    }

    internal class BetterSubscriber
    {
        public void Execute(object send, MyEventArgs e)
        {
            Console.WriteLine($"我在执行，事件源是{send.ToString()},事件参数MyEventArgs内有数据{e.Name}:{e.Value}");
        }

        //特别说明：
        //如果在 Subscribe内写，publiser.myEvent += subscriber.Execute;
        //封装性更好，但其也对publisher形成了依赖，因此需要通过构造函数等方式将publisher注入进来，比如
        /*
        private Publiser publiser = null;
        public Subscriber(Publiser publiser)
        {
            this.publiser = publiser;
        }
        */
    }

    internal class BetterClient
    {
        

        public static void Index()
        {
            BetterPubliser publiser = new BetterPubliser();
            BetterSubscriber subscriber = new BetterSubscriber();

            //在客户程序里面，进行订阅操作，这样虽然让客户知道的有点多，但解耦了订阅者和发布者的关系。
            publiser.myEvent += subscriber.Execute;
            publiser.Publish();
        }
    }
}

/**
 * @file   : 内置事件模型使用.cs
 * @date   : 2024/7/6 10:17:16
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.事件研究._3.框架标准事件
{
    internal class Publiser
    {
        public event EventHandler myEvent;
        public void Publish()
        {
            myEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    internal class Subscriber
    {
        public void Execute(object send, EventArgs e)
        {
            Console.WriteLine($"我在执行，事件源是{send.ToString()},但事件参数EventArgs无法传递更多数据");
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

    internal class Client
    {
        Publiser publiser = new Publiser();
        Subscriber subscriber = new Subscriber();

        public void Index()
        {
            //在客户程序里面，进行订阅操作，这样虽然让客户知道的有点多，但解耦了订阅者和发布者的关系。
            publiser.myEvent += subscriber.Execute;
            publiser.Publish();
        }
    }
}

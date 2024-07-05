/**
 * @file   : Client.cs
 * @date   : 2024/7/5 15:55:17
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅方法的方式
{
    internal class Client
    {
        public static void Index()
        {
            // 使用示例
            MessageBroker<string> broker = new MessageBroker<string>();
            Publisher<string> publisher = new Publisher<string>(broker);

            Subscriber<string> subscriber1 = new Subscriber<string>("Alice");
            Subscriber<string> subscriber2 = new Subscriber<string>("Bob");
            Subscriber<string> subscriber3 = new Subscriber<string>("Ajax");

            //客户端完成订阅过程。
            broker.Subscribe("news", subscriber1.Execute);
            broker.Subscribe("weather", subscriber2.Execute);
            broker.Subscribe("weather", subscriber3.Execute);

            subscriber1.Subscribe("news");
            subscriber2.Subscribe("weather");
            subscriber3.Subscribe("weather");

            publisher.Publish("news", "Breaking news: the sky is blue");
            publisher.Publish("weather", "It will be sunny tomorrow");
        }
    }
}

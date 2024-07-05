/**
 * @file   : Client.cs
 * @date   : 2024/7/5 15:55:17
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅对象的方式
{
    internal class Client
    {
        public static void Index()
        {
            // 使用示例
            MessageBroker broker = new MessageBroker();
            Publisher publisher = new Publisher(broker);

            Subscriber subscriber1 = new Subscriber("Alice", broker);
            Subscriber subscriber2 = new Subscriber("Bob", broker);
            Subscriber subscriber3 = new Subscriber("Ajax", broker);

            broker.Subscribe("news", subscriber1);
            broker.Subscribe("weather", subscriber2);
            broker.Subscribe("weather", subscriber3);

            publisher.Publish("news", ">>Breaking news: the sky is blue");
            publisher.Publish("weather", ">>It will be sunny tomorrow");
        }
    }
}

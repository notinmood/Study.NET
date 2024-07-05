/**
 * @file   : Client.cs
 * @date   : 2024/7/5 15:55:17
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.标准实现方式
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

            subscriber1.Subscribe("news");
            subscriber2.Subscribe("weather");
            subscriber3.Subscribe("weather");

            publisher.Publish("news", "Breaking news: the sky is blue");
            publisher.Publish("weather", "It will be sunny tomorrow");
        }
    }
}

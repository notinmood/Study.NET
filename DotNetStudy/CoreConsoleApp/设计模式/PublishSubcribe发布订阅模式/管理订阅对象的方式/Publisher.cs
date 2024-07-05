/**
 * @file   : Publisher.cs
 * @date   : 2024/7/5 15:36:09
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅对象的方式
{
    internal class Publisher : IPublish
    {
        public Publisher(MessageBroker broker)
        {
            this.broker = broker;
        }

        private readonly MessageBroker broker;

        public void Publish<T>(string topic, T message)
        {
            this.broker.Publish(topic, message);
        }
    }
}

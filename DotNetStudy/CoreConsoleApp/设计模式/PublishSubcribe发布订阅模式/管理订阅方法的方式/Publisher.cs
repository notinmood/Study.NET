/**
 * @file   : Publisher.cs
 * @date   : 2024/7/5 15:36:09
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅方法的方式
{
    internal class Publisher<T> : IPublish<T>
    {
        public Publisher(MessageBroker<T> broker)
        {
            this.broker = broker;
        }

        private readonly MessageBroker<T> broker;

        public void Publish(string topic, T message)
        {
            this.broker.Publish(topic, message);
        }
    }
}
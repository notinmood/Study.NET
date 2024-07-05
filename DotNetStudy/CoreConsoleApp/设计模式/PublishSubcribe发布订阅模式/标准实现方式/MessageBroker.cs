

using System.Collections.Generic;

/**
 * @file   : MessageBroker.cs
 * @date   : 2024/7/5 15:06:21
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.标准实现方式
{
    internal class MessageBroker
    {
        private Dictionary<string, List<ISubcribe>> allSubcribers = new();
        public MessageBroker()
        {

        }

        public void Subscribe(string topic, ISubcribe subcriber)
        {
            if (!allSubcribers.TryGetValue(topic, out List<ISubcribe> topicSubscribers))
            {
                topicSubscribers = ([]);
                this.allSubcribers[topic] = topicSubscribers;
            }

            topicSubscribers.Add(subcriber);
        }

        public void publish<T>(string topic,T data)
        {
            if (!this.allSubcribers.ContainsKey(topic))
            {
                return;
            }

            var topicSubscribers= this.allSubcribers[topic];
            foreach (var subscriber in topicSubscribers)
            {
                subscriber.Execute(data);
            }
        }
    }
}
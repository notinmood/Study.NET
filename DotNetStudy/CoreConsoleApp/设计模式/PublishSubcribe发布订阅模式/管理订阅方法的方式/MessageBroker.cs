/**
 * @file   : MessageBroker.cs
 * @date   : 2024/7/5 15:06:21
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅方法的方式
{
    internal class MessageBroker<T>
    {
        private Dictionary<string, List<ExecuteMethod<T>>> allSubcribers = new();
        public MessageBroker()
        {

        }

        /**
         * 重点：此处使用委托代表具体要订阅事件，然后触发的方法。而不使用具体的订阅者对象，这就摆脱了对订阅者的依赖。
         */
        public void Subscribe(string topic, ExecuteMethod<T> subcriber)
        {
            if (!allSubcribers.TryGetValue(topic, out List<ExecuteMethod<T>> topicSubscribers))
            {
                topicSubscribers = ([]);
                this.allSubcribers[topic] = topicSubscribers;
            }

            topicSubscribers.Add(subcriber);
        }

        public void Publish(string topic, T data)
        {
            if (!this.allSubcribers.ContainsKey(topic))
            {
                return;
            }

            var topicSubscribers = this.allSubcribers[topic];
            foreach (var subscriber in topicSubscribers)
            {
                subscriber(data);
            }
        }
    }
}
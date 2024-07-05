﻿

using System;

/**
 * @file   : Subscriber.cs
 * @date   : 2024/7/5 15:40:53
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.标准实现方式
{
    internal class Subscriber : ISubcribe
    {
        private readonly MessageBroker broker;
        private readonly string name;

        public Subscriber(string name, MessageBroker broker)
        {
            this.broker = broker;
            this.name = name;
        }

        public void Subscribe(string topic)
        {
            this.broker.Subscribe(topic, this);
        }

        public void Execute<T>(T data)
        {
            Console.WriteLine("动作执行中。。。");
            Console.WriteLine(data.ToString());
        }
    }
}

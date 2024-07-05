

using System;

/**
 * @file   : Subscriber.cs
 * @date   : 2024/7/5 15:40:53
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅对象的方式
{
    internal class Subscriber : ISubcribe
    {
        private readonly string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void Execute<T>(T data)
        {
            Console.WriteLine("我的动作执行中。。。");
            Console.WriteLine(data.ToString());
        }
    }
}

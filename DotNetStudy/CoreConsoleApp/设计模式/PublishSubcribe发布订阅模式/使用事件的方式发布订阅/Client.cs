/**
 * @file   : Client.cs
 * @date   : 2024/7/5 20:24:56
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.使用事件的方式发布订阅
{
    internal class Client
    {
        public static void Index()
        {
            MyEventPublisher publisher = new MyEventPublisher();
            MyEventListener listener = new MyEventListener();

            // 将事件处理方法绑定到事件
            publisher.MyEvent += listener.OnMyEvent;

            // 触发事件
            publisher.RaiseMyEvent("Hello, world!");

            // 移除事件处理方法
            publisher.MyEvent -= listener.OnMyEvent;

            Console.ReadLine();
        }
    }
}

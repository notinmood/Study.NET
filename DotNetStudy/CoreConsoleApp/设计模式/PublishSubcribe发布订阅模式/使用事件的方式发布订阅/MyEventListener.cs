/**
 * @file   : MyEventListener.cs
 * @date   : 2024/7/5 20:24:01
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.使用事件的方式发布订阅
{
    // 定义一个类，它将作为事件订阅者
    public class MyEventListener
    {
        // 事件处理方法，必须匹配委托签名
        public void OnMyEvent(string message)
        {
            Console.WriteLine($"Event received: {message}");
        }
    }
}

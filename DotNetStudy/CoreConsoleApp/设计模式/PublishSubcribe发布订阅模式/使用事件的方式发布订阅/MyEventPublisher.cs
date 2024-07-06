/**
 * @file   : MyEventPublisher.cs
 * @date   : 2024/7/5 20:22:49
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.使用事件的方式发布订阅
{
    // 定义一个类，它包含一个事件
    public class MyEventPublisher
    {
        // 声明一个事件
        public event MyEventHandler MyEvent;

        // 一个方法，当某些条件满足时会触发事件
        public void RaiseMyEvent(string message)
        {
            // 检查是否有对象监听这个事件
            MyEvent?.Invoke(message);
        }
    }
}
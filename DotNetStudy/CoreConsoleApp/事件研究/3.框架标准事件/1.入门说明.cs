/**
 * @file   : 入门.cs
 * @date   : 2024/7/6 10:06:36
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.事件研究._3.框架标准事件
{
    internal class 入门说明
    {
        //1. 因为订阅发布模型有相对固定的模式，因此dotNET框架内置了这种固定模型的委托，类似如下：
        //其中，参数sender表示事件源（即发布者），参数e是要从发布者传递到订阅者的数据
        public delegate void EventHandler(object sender, EventArgs e);

        //2. 再使用此委托和event关键字定义事件
        public event EventHandler MyEvent;

        //3. 内置的事件模型参数EventArgs，无法传递更多数据，因此微软又提供了一个泛型版的事件模型，类似如下：
        public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e) where TEventArgs : EventArgs, new();
        //这样就可以根据需要自定义TEventArgs，使其携带更多业务数据了。（具体参看3.内置事件模型扩充.cs）
    }
}
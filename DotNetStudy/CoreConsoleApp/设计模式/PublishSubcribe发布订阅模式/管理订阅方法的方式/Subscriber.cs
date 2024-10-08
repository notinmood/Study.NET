﻿/**
 * @file   : Subscriber.cs
 * @date   : 2024/7/5 15:40:53
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅方法的方式
{
    internal class Subscriber<T> : ISubcribe<T>
    {
        private readonly string name;

        public Subscriber(string name)
        {
            this.name = name;
        }


        public void Execute(T data)
        {
            Console.WriteLine("动作执行中。。。");
            Console.WriteLine(data.ToString());
        }
    }
}
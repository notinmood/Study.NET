/**
 * @file   : Client.cs
 * @date   : 2024/7/8 8:33:54
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Builder构造器模式.场景2.X.对象构建示例.NoPattern
{
    internal class Client
    {
        public static void Index()
        {
            //1. 使用多参数的构造函数。参数太多，非常容易让人迷惑。
            Task task1 = new Task("考试", 1, DateTime.Today, DateTime.Today, 1, "期末考试");

            //2. 使用setter方式给创建后的实例属性赋值。容易漏掉一些参数，创建不完整的对象实例，并且很难检查出来。
            Task task2 = new Task();
            task2.Count = 1;
            task2.Name = "Test";
            task2.CreateTime = DateTime.Now;
            //task2.UpdateTime= DateTime.Now;
            task2.Description = "这是一个测试";
            task2.Level = 1;
        }
    }
}

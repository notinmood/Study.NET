/**
 * @file   : Client.cs
 * @date   : 2024/7/8 8:57:01
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Builder构造器模式.X.对象构建示例.UsePattern
{
    internal class Client
    {
        public static void Index()
        {
            var builder = new Task.Builder();
            Task task = builder.SetCount(1)
                .SetName("Exam")
                .SetLevel(1)
                .SetCreateTime(DateTime.Now)
                .SetUpdateTime(DateTime.Now)
                .SetDescription("this is an exam!")
                .Build();
            Console.WriteLine(task);

        }
    }
}

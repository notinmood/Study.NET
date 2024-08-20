/**
 * @file   : 创建Task的几种方法.cs
 * @date   : 2024/8/20 18:24:47
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Threading.Tasks;

#pragma warning disable
namespace CoreConsoleApp.异步和多线程.Task的使用
{
    static class 创建Task的几种方法
    {
        public static void Index()
        {
            // 1.使用new创建Task
            Task task1 = new Task(new Action(() =>
            {
                Console.WriteLine("Hello Task1");
            }));
            task1.Start();

            // 2.使用 Task.Run 创建Task
            Task task2 = Task.Run(() =>
            {
                Console.WriteLine("Hello Task2");
            });

            // 3.使用Factory.StartNew创建Task
            Task task3 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Hello Task3");
            });
        }
    }
}

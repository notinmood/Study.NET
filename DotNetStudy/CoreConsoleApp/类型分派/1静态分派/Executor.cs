/**
 * @file   : Executor.cs
 * @date   : 2024/8/1 19:24:29
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.类型分派.静态分派
{
    public class Executor
    {
        public void execute(IMove a)
        {
            Console.WriteLine("IMove...");
        }

        public void execute(Animal a)
        {
            Console.WriteLine("animal");
        }
        public void execute(Dog d)
        {
            Console.WriteLine("dog");
        }
        public void execute(Cat c)
        {
            Console.WriteLine("cat");
        }
    }
}

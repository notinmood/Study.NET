/**
 * @file   : Dog.cs
 * @date   : 2024/8/1 20:05:51
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.类型分派.动态分派
{
    public class Dog : Animal
    {
        public override void Execute()
        {
            Console.WriteLine("dog");
        }
    }
}

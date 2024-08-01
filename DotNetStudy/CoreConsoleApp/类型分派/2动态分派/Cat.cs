/**
 * @file   : Cat.cs
 * @date   : 2024/8/1 20:06:49
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;


namespace CoreConsoleApp.类型分派.动态分派
{
    public class Cat : Animal
    {
        public override void Execute()
        {
            Console.WriteLine("cat");
        }
    }
}

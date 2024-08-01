

using System;

/**
 * @file   : Cat.cs
 * @date   : 2024/8/1 20:23:20
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.类型分派.双方派
{
    public class Cat : Animal
    {
        public override void accept(Executor exe)
        {
            Console.WriteLine("在Cat上调用Accept方法");
            exe.Execute(this); // 第二次分派
        }
    }
}

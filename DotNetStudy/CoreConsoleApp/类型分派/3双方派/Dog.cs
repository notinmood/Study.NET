/**
 * @file   : Dog.cs
 * @date   : 2024/8/1 20:22:58
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.类型分派.双方派
{
    public class Dog : Animal
    {
        public override void accept(Executor exe)
        {
            Console.WriteLine("在Dog上调用Accept方法");
            exe.Execute(this); // 第二次分派
        }
    }
}

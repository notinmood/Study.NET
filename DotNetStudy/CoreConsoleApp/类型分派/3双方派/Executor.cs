/**
 * @file   : Executor.cs
 * @date   : 2024/8/1 20:23:47
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
    public class Executor
    {
        public void Execute(Animal a)
        {
            Console.WriteLine("animal");
        }
        public void Execute(Dog d)
        {
            Console.WriteLine("dog");
        }
        public void Execute(Cat c)
        {
            Console.WriteLine("cat");
        }
    }
}

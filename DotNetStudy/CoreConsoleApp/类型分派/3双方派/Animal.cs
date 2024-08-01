/**
 * @file   : Animal.cs
 * @date   : 2024/8/1 20:22:33
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
    public class Animal
    {
        public virtual void accept(Executor exe)
        {
            Console.WriteLine("在Animal上调用Accept方法");
            exe.Execute(this); // 第二次分派
        }
    }
}

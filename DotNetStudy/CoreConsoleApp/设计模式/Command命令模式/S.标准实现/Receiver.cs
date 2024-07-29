/**
 * @file   : Receiver.cs
 * @date   : 2024/7/29 21:29:09
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.Command命令模式.S.标准实现
{
    //接收者
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("执行具体操作");
        }
    }
}

/**
 * @file   : Invoker.cs
 * @date   : 2024/7/29 21:28:36
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
    //请求者
    public class Invoker
    {
        private readonly ICommand cmd;

        public Invoker(ICommand cmd)
        {
            this.cmd = cmd;
        }

        public void Action()
        {
            this.cmd.Execute();
        }
    }
}

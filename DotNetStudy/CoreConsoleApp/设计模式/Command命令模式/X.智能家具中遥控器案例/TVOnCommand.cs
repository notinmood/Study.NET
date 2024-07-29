/**
 * @file   : TVOnCommand.cs
 * @date   : 2024/7/29 22:00:05
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.Command命令模式.X.智能家具中遥控器案例
{
    // 电视机具体命令
    public class TVOnCommand : ICommand
    {
        // 聚合TVReceiver
        readonly TVReceiver tv;

        // 构造器
        public TVOnCommand(TVReceiver tv) : base()
        {
            this.tv = tv;
        }

        public void execute()
        {
            // 调用接收者的方法
            tv.on();
        }

        public void undo()
        {
            // 调用接收者的方法
            tv.off();
        }
    }
}

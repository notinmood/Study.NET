/**
 * @file   : TVOffCommand.cs
 * @date   : 2024/7/29 21:59:20
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
    public class TVOffCommand : ICommand
    {
        // 聚合TVReceiver
        readonly TVReceiver tv;

        // 构造器
        public TVOffCommand(TVReceiver tv) : base()
        {
            this.tv = tv;
        }

        public void execute()
        {
            // 调用接收者的方法
            tv.off();
        }

        public void undo()
        {
            // 调用接收者的方法
            tv.on();
        }
    }
}

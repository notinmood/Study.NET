/**
 * @file   : LightReceiver.cs
 * @date   : 2024/7/29 21:50:57
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreConsoleApp.设计模式.Command命令模式.X.智能家具中遥控器案例;

namespace CoreConsoleApp.设计模式.Command命令模式.X.智能家具中遥控器案例
{
    // 电灯Receiver
    public class LightReceiver
    {

        public void on()
        {
            Console.WriteLine(" 电灯打开了.. ");
        }

        public void off()
        {
            Console.WriteLine(" 电灯关闭了.. ");
        }
    }
    



}

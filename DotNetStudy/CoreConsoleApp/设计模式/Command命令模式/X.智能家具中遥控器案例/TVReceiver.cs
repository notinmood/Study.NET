

using System;

/**
 * @file   : TVReceiver.cs
 * @date   : 2024/7/29 21:57:01
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.设计模式.Command命令模式.X.智能家具中遥控器案例
{
    // 电视机Receiver
    public class TVReceiver
    {

        public void on()
        {
            Console.WriteLine(" 电视机打开了.. ");
        }

        public void off()
        {
            Console.WriteLine(" 电视机关闭了.. ");
        }
    }    
}

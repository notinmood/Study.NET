/**
 * @file   : Client.cs
 * @date   : 2024/7/29 22:15:51
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
    // 客户端
    public static class Client
    {
        public static void Index()
        {
            //使用命令设计模式，完成通过遥控器，对电灯的操作
            Console.WriteLine("=========使用遥控器操作电灯==========");

            //创建电灯的对象(接受者)
            LightReceiver lightReceiver = new LightReceiver();

            //创建电灯相关的开关命令
            LightOnCommand lightOnCommand = new LightOnCommand(lightReceiver);
            LightOffCommand lightOffCommand = new LightOffCommand(lightReceiver);

            //需要一个遥控器
            RemoteController remoteController = new RemoteController();

            //给我们的遥控器设置命令, 比如 no = 0 是电灯的开和关的操作
            remoteController.setCommand(0, lightOnCommand, lightOffCommand);

            Console.WriteLine("--------按下灯的开按钮-----------");
            remoteController.onButtonWasPushed(0);
            Console.WriteLine("--------按下灯的关按钮-----------");
            remoteController.offButtonWasPushed(0);
            Console.WriteLine("--------按下撤销按钮-----------");
            remoteController.undoButtonWasPushed();


            Console.WriteLine("=========使用遥控器操作电视机==========");

            TVReceiver tvReceiver = new TVReceiver();

            TVOffCommand tvOffCommand = new TVOffCommand(tvReceiver);
            TVOnCommand tvOnCommand = new TVOnCommand(tvReceiver);

            //给我们的遥控器设置命令, 比如 no = 1 是电视机的开和关的操作
            remoteController.setCommand(1, tvOnCommand, tvOffCommand);

            Console.WriteLine("--------按下电视机的开按钮-----------");
            remoteController.onButtonWasPushed(1);
            Console.WriteLine("--------按下电视机的关按钮-----------");
            remoteController.offButtonWasPushed(1);
            Console.WriteLine("--------按下撤销按钮-----------");
            remoteController.undoButtonWasPushed();
        }
    }
}

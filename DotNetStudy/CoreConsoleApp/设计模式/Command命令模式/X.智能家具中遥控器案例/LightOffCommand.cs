/**
 * @file   : LightOffCommand.cs
 * @date   : 2024/7/29 21:51:44
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Command命令模式.X.智能家具中遥控器案例
{
    // 电灯具体命令类
    public class LightOffCommand : ICommand
    {
        // 聚合LightReceiver
        readonly LightReceiver light;

        // 构造器
        public LightOffCommand(LightReceiver light) : base()
        {
            this.light = light;
        }

        public void execute()
        {
            // 调用接收者的方法
            light.off();
        }

        public void undo()
        {
            // 调用接收者的方法
            light.on();
        }
    }
}

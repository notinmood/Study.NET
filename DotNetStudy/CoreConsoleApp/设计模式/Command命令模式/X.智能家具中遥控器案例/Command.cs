/**
 * @file   : Command.cs
 * @date   : 2024/7/29 21:46:49
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Command命令模式.X.智能家具中遥控器案例
{
    //创建命令接口
    public interface ICommand
    {
        //执行动作(操作)
        void execute();
        //撤销动作(操作)
        void undo();
    }





}

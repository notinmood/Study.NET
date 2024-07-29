/**
 * @file   : NoCommand.cs
 * @date   : 2024/7/29 21:47:31
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Command命令模式.X.智能家具中遥控器案例
{
    /**
     * 没有任何命令，即空执行: 用于初始化每个按钮, 当调用空命令时，对象什么都不做
     * 其实，这样是一种设计模式, 可以省掉对空判断
     */
    public class NoCommand : ICommand
    {
        public void execute()
        {
        }

        public void undo()
        {
        }
    }
}

/**
 * @file   : RemoteController.cs
 * @date   : 2024/7/29 22:10:33
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Command命令模式.X.智能家具中遥控器案例
{
    // 控制器，Invoker角色
    public class RemoteController
    {
        // 开 按钮的命令数组
        readonly ICommand[] onCommands;
        readonly ICommand[] offCommands;

        // 执行撤销的命令
        ICommand undoCommand;

        // 构造器，完成对按钮初始化
        public RemoteController()
        {
            onCommands = new ICommand[5];
            offCommands = new ICommand[5];

            for (int i = 0; i < 5; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
        }

        // 给我们的按钮设置你需要的命令
        public void setCommand(int number, ICommand onCommand, ICommand offCommand)
        {
            onCommands[number] = onCommand;
            offCommands[number] = offCommand;
        }

        // 按下开按钮
        public void onButtonWasPushed(int number)
        {
            // no 0
            // 找到你按下的开的按钮， 并调用对应方法
            onCommands[number].execute();
            // 记录这次的操作，用于撤销
            undoCommand = onCommands[number];
        }

        // 按下开按钮
        public void offButtonWasPushed(int number)
        {
            // no 0
            // 找到你按下的关的按钮， 并调用对应方法
            offCommands[number].execute();
            // 记录这次的操作，用于撤销
            undoCommand = offCommands[number];
        }

        // 按下撤销按钮
        public void undoButtonWasPushed()
        {
            undoCommand.undo();
        }
    }
}

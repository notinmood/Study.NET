/**
 * @file   : ConcreteCommand.cs
 * @date   : 2024/7/29 21:27:24
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Command命令模式.S.标准实现
{
    //具体命令
    public class ConcreteCommand : ICommand
    {
        // 直接创建接收者，不暴露给客户端
        private readonly Receiver receiver;

        public ConcreteCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            this.receiver.Action();
        }
    }
}

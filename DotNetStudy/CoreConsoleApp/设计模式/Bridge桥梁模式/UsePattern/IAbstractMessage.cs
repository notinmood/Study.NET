using System;

namespace CoreConsoleApp.设计模式.Bridge桥梁模式.UsePattern
{
    public abstract class IAbstractMessage
    {
        //持有一个实现部分的对象
        IMessageImplementor impl;
        /**
         * 构造方法，传入实现部分的对象
         * @param impl  实现部分的对象
         */
        public IAbstractMessage(IMessageImplementor impl)
        {
            this.impl = impl;
        }
        /**
         * 发送消息，委派给实现部分的方法
         * @param message    要发送消息的内容
         * @param toUser    消息的接受者
         */
        public virtual void SendMessage(string message, string toUser)
        {
            this.impl.Send(message, toUser);
        }
    }
}

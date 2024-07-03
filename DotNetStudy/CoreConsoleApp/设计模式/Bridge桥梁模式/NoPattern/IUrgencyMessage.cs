using System;

namespace CoreConsoleApp.设计模式.Bridge桥梁模式.NoPattern
{
    internal interface IUrgencyMessage : IMessage
    {
        /**
         * 监控指定消息的处理过程
         * @param messageId  被监控的消息编号
         * @return    监控到的消息的处理状态
         */
        public object Watch(string messageId);

    }
}

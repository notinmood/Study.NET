using System;

namespace CoreConsoleApp.设计模式.Bridge桥梁模式.NoPattern
{
    public interface IMessage
    {
        /**
         * 发送消息
         * @param message 要发送消息的内容
         * @param toUser  消息的接受者
         */
        public void Send(string message, string toUser);
    }
}

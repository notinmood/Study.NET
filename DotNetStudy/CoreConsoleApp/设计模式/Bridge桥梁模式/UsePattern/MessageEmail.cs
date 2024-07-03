using System;

namespace CoreConsoleApp.设计模式.Bridge桥梁模式.UsePattern
{
    public class MessageEmail : IMessageImplementor
    {
        public void Send(string message, string toUser)
        {
            Console.WriteLine("使用邮件短消息的方法，发送消息'" + message + "'给" + toUser);
        }
    }
}

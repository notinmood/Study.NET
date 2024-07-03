using System;

namespace CoreConsoleApp.设计模式.Bridge桥梁模式.NoPattern
{
    public class CommonMessageSMS : IMessage
    {

        public void Send(String message, String toUser)
        {

            Console.WriteLine("使用系统内短消息的方法，发送消息'" + message + "'给" + toUser);
        }
    }
}

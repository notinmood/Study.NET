using System;

namespace CoreConsoleApp.设计模式.Bridge桥梁模式.NoPattern
{
    public class UrgencyMessageSMS : IUrgencyMessage
    {
        public object Watch(string messageId)
        {
            // 根据消息id获取消息的状态，组织成监控的数据对象，然后返回
            return null;
        }


        public void Send(string message, string toUser)
        {
            message = "加急：" + message;
            Console.WriteLine("使用系统内短消息的方法，发送消息'" + message + "'给" + toUser);
        }
    }
}

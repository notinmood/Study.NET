using System;

namespace CoreConsoleApp.设计模式.Bridge桥梁模式.NoPattern
{
    public class UrgencyMessageEmail : IUrgencyMessage
    {
        public Object Watch(String messageId)
        {
            // 根据消息id获取消息的状态，组织成监控的数据对象，然后返回
            return null;
        }

        public void Send(String message, String toUser)
        {
            message = "加急：" + message;
            Console.WriteLine("使用邮件短消息的方法，发送消息'" + message + "'给" + toUser);
        }
    }
}

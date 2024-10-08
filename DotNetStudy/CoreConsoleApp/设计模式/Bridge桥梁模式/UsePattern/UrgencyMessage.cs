﻿namespace CoreConsoleApp.设计模式.Bridge桥梁模式.UsePattern
{
    public class UrgencyMessage : IAbstractMessage
    {

        public UrgencyMessage(IMessageImplementor impl) : base(impl)
        {

        }

        public override void SendMessage(string message, string toUser)
        {
            message = "加急：" + message;
            base.SendMessage(message, toUser);
        }

        /**
        * 扩展自己的新功能，监控某消息的处理状态
        * @param messageId 被监控的消息编号
        * @return 监控到的消息的处理状态
        */
        public object Watch(string messageId)
        {
            // 根据消息id获取消息的状态，组织成监控的数据对象，然后返回
            return null;
        }
    }
}

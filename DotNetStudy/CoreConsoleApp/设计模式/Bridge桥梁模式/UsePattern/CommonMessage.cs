namespace CoreConsoleApp.设计模式.Bridge桥梁模式.UsePattern
{
    public class CommonMessage : IAbstractMessage
    {
        public CommonMessage(IMessageImplementor impl) : base(impl)
        {

        }


        public override void SendMessage(string message, string toUser)
        {
            // 对于普通消息，直接调用父类方法，发送消息即可
            base.SendMessage(message, toUser);
        }
    }
}

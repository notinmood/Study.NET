namespace CoreConsoleApp.设计模式.Bridge桥梁模式.UsePattern
{
    public class Client
    {
        public static void Index()
        {
            //创建具体的实现对象
            IMessageImplementor impl = new MessageSMS();
            //创建普通消息对象
            IAbstractMessage message = new CommonMessage(impl);
            message.SendMessage("加班申请速批", "李总");

            //将实现方式切换成邮件，再次发送
            impl = new MessageEmail();
            //创建加急消息对象
            message = new UrgencyMessage(impl);
            message.SendMessage("加班申请速批", "李总");
        }
    }
}
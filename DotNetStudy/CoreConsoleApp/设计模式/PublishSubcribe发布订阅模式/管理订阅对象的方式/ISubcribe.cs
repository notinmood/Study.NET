namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅对象的方式
{
    internal interface ISubcribe
    {
        void Subscribe(string topic);
        void Execute<T>(T data);
    }
}

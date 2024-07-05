namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.标准实现方式
{
    internal interface ISubcribe
    {
        void Subscribe(string topic);
        void Execute<T>(T data);
    }
}

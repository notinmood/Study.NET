namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅方法的方式
{
    internal interface IPublish<T>
    {
        void Publish(string topic, T data);
    }
}
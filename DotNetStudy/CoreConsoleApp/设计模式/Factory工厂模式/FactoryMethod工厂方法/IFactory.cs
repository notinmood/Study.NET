using CoreConsoleApp.设计模式.Factory工厂模式.Biz;

namespace CoreConsoleApp.设计模式.Factory工厂模式.FactoryMethod工厂方法
{
    internal interface IFactory
    {
        Enemy Create(int width);
    }
}

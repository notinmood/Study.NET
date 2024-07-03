using CoreConsoleApp.设计模式.Factory工厂模式.Biz;

namespace CoreConsoleApp.设计模式.Factory工厂模式.FactoryMethod工厂方法
{
    internal class Client
    {
        public void Index()
        {
            IFactory factory = null;

            factory = new TankFactory();
            Enemy tank = factory.Create(100);
            tank.Show();

            factory = new AirplaneFactory();
            Enemy airplane = factory.Create(100);
            airplane.Show();
        }
    }
}

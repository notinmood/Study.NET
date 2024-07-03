using CoreConsoleApp.设计模式.Factory工厂模式.Biz;

namespace CoreConsoleApp.设计模式.Factory工厂模式.ReflectFactory反射工厂
{
    internal class Client
    {
        public static void Index()
        {
            Enemy tank = ReflectFactory.Create("Tank",100);
            tank.Show();

            Enemy airplane = ReflectFactory.Create("Airplane",100);
            airplane.Show();
        }
    }
}

using System;
using CoreConsoleApp.设计模式.Factory工厂模式.Biz;

namespace CoreConsoleApp.设计模式.Factory工厂模式.FactoryMethod工厂方法
{
    internal class TankFactory : IFactory
    {
        public Enemy Create(int width)
        {
            Random random = new Random();
            Enemy enemy = new Tank(random.Next(width), 0);
            return enemy;
        }
    }
}

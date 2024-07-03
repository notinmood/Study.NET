using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreConsoleApp.设计模式.Factory工厂模式.Biz;

namespace CoreConsoleApp.设计模式.Factory工厂模式.FactoryMethod工厂方法
{
    internal class AirplaneFactory : IFactory
    {
        public Enemy Create(int width)
        {
            Random random = new Random();
            Enemy enemy = new Airplane(random.Next(width), 0);
            return enemy;
        }
    }
}

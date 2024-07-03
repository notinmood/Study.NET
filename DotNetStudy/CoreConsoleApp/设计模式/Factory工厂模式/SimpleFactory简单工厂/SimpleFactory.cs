using System;
using CoreConsoleApp.设计模式.Factory工厂模式.Biz;

namespace CoreConsoleApp.设计模式.Factory工厂模式.SimpleFactory简单工厂
{
    internal class SimpleFactory
    {
        private int screenWidth;
        private Random random;//随机数
        public SimpleFactory(int screenWidth)
        {
            this.screenWidth = screenWidth;
            this.random = new Random();
        }
        public Enemy Create(string type)
        {
            int x = random.Next(screenWidth);// 生成敌人横坐标随机数
            Enemy enemy = null;
            switch (type)
            {
                case "Airplane":
                    enemy = new Airplane(x, 0);// 实例化飞机
                    break;
                case "Tank":
                    enemy = new Tank(x, 0);// 实例化坦克
                    break;
            }
            return enemy;
        }
    }
}

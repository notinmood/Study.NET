using System;
using CoreConsoleApp.设计模式.Factory工厂模式.Biz;

namespace CoreConsoleApp.设计模式.Factory工厂模式.NoFactory
{
    internal class Client
    {
        public void Index()
        {
            /**
             * 在客户端代码中直接生成目标对象
             * 缺点：
             * 1. 有多少目标对象，就要调用多少次构造函数；
             * 2. 如果构造对象时候条件非常复杂，就更不容易实现。
             */
            int screenWidth = 100;//屏幕宽度
            Console.WriteLine("游戏开始");
            Random random = new();//准备随机数

            int x = random.Next(screenWidth);//生成敌机横坐标随机数
            Enemy airplane = new Airplane(x, 0);//实例化飞机
            airplane.Show();//显示飞机

            x = random.Next(screenWidth);//姐克同上
            Enemy tank = new Tank(x, 0);
            tank.Show();
        }
    }
}

using CoreConsoleApp.设计模式.Factory工厂模式.Biz;

namespace CoreConsoleApp.设计模式.Factory工厂模式.SimpleFactory简单工厂
{
    internal class Client
    {
        /// <summary>
        /// 
        /// </summary>
        public void Index()
        {
            /**
             * 使用简单工厂后，就把相对复杂的对象创建工作统一管理起来了。
             * 1. 无论是创建多个对象，
             * 2. 还是创建条件复杂的对象。
             * 都统一管理起来后，客户端只需要调用这个工厂就好了。
             */
            SimpleFactory factory = new(100);

            Enemy airplane = factory.Create("Airplane");
            airplane.Show();

            Enemy tank = factory.Create("Tank");
            tank.Show();
        }
    }
}

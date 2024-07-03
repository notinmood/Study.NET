namespace CoreConsoleApp.设计模式.Singleton单例模式._2.懒汉式_优化_线程安全但性能不高_
{
    /// <summary>
    /// 这种方式具备很好的 lazy loading，能够在多线程中很好的工作，
    /// 但是，效率很低，99% 情况下不需要同步，下面的案例会对此进行优化！

    /// 优点：第一次调用才初始化，避免内存浪费。
    /// 缺点：lock(或者java下的synchronized)加锁可以保证单例，但每次调用实例时都加锁，会影响效率。
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;
        private Singleton() { }
        public static Singleton getInstance()
        {
            //重点：通过lock加锁。防止其他线程同时访问本段代码，从而避免了多个instance的出现。
            lock (Singleton.instance)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
            return instance;
        }
    }
}

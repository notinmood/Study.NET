namespace CoreConsoleApp.设计模式.Singleton单例模式._1.懒汉式_线程不安全_
{
    /// <summary>
    /// 说明：
    /// 这种实现方式的一个特点是只有在需要使用单例对象时才会进行实例化，而不是在程序
    /// 启动时就创建单例对象。这种延迟创建的方式可以在某些情况下节省资源，特别是在
    /// 单例对象比较复杂或者初始化耗时较长时。
    /// 
    /// 需要注意的是，该代码示例并不是线程安全的。在多线程环境下，可能会导致多个线程
    /// 同时检测到instance为空，从而创建多个实例。为了实现线程安全的懒加载单例模式，
    /// 可以使用双重检查锁（double-checked locking）或者其他线程安全的方式对getInstance()
    /// 方法进行改进。
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;
        private Singleton() { }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}

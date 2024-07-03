namespace CoreConsoleApp.设计模式.Singleton单例模式._3.饿汉式
{
    /// <summary>
    /// 这种方式基于 classloader （类加载）机制避免了多线程同步的问题，
    /// instance在类装载时候就实例化，显然导致类装载的原因有很多种：
    /// 在单例模式中大多数都是调用 getInstance 方法；但也有可能使用了其他方法（其他静态方法）导致类装载。
    /// 这种初始化 instance 显然没有达到 lazy loading 的效果。

    /// 优点：没有加锁，执行效率会提高。
    /// 缺点：类加载时就初始化，浪费内存。
    /// </summary>
    public class Singleton
    {
        //重点：在类型（可以是类型的任意静态成员或者实例成员）第一次被调用的时候，
        //就直接创建实例。并且这种实例的创建是类加载机制自动保证的线程安全。
        private static Singleton instance = new Singleton();
        private Singleton() { }
        public static Singleton getInstance()
        {
            return instance;
        }
    }
}

namespace CoreConsoleApp.设计模式.Singleton单例模式._5.静态内部类
{
    /// <summary>
    /// 这种方式能实现和双检锁方式一样的功效，但实现更简单。
    /// 
    /// 如果实例化 instance 很消耗资源，所以想让它延迟加载，
    /// 另外一方面，又不希望在 Singleton 类加载时就实例化，
    /// 因为不能确保 Singleton 类还可能在其他的地方被主动使用从而被加载，
    /// 那么这个时候实例化 instance 显然是不合适的。
    /// 这个时候，使用本种方式就很合理：即可以延迟加载，又只有当明确
    /// 使用SingleonHolder.INSTANCE才能初始化实例（单例），从而实例化 instance。
    /// </summary>
    public class Singleton
    {
        private static class SingletonHolder
        {
            internal static Singleton INSTANCE = new Singleton();
        }
        private Singleton() { }
        public static Singleton getInstance()
        {
            return SingletonHolder.INSTANCE;
        }
    }
}

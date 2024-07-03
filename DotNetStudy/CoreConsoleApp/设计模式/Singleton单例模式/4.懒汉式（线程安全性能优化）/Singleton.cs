namespace CoreConsoleApp.设计模式.Singleton单例模式._4.懒汉式_线程安全性能优化_
{
    /// <summary>
    /// 双重检查锁（double-checked & locking）方式。这是推荐的方式。
    /// 在第一次检查时：如果instance为空，才会进入同步块；如果不为空，则可以直接返回实例。
    /// 对性能的提高非常有效。进入同步块后，再次检查instance是否为空，以确保只有一个线程创建实例。

    /// 使用volatile关键字修饰instance变量，可以确保在多线程环境下对其的可见性和禁止指令重排序。
    /// 这样可以避免在某些情况下获取到一个尚未完全初始化的实例。（多线程可见性的意思是，
    /// 某个线程对变量的修改是直接反映在内存上，而不是缓存上。在内存上修改变量，其他线程可以立即查看到，
    /// 但缓存上部可以（因为每个线程都有自己的独立的缓存）。）

    /// 通过双重检查锁和volatile关键字的改进，可以保证在多线程环境下只有一个实例被创建，
    /// 并且在需要时进行懒加载。
    /// </summary>
    public class Singleton
    {
        // 使用volatile修饰，确保可见性和禁止指令重排。
        private static volatile Singleton instance;

        private Singleton() { }

        public static Singleton getInstance()
        {
            // 第一次检查，避免不必要的同步
            if (instance == null)
            {
                //锁定代码段，只能为一个线程提供本段代码的同时访问权限。
                lock (Singleton.instance)
                {
                    // 第二次检查，确保只有一个线程创建实例
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}

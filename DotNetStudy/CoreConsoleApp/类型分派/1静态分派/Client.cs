/**
 * @file   : Client.cs
 * @date   : 2024/8/1 19:50:10
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.类型分派.静态分派
{
    public static class Client
    {
        public static void Index()
        {
            Animal a = new Animal();
            Animal a1 = new Dog();
            Animal a2 = new Cat();
            Executor exe = new Executor();
            exe.execute(a); // animal
            exe.execute(a1); // animal
            exe.execute(a2); // animal
        }
    }
}

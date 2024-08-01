/**
 * @file   : Client.cs
 * @date   : 2024/8/1 20:19:15
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.类型分派.双方派
{
    public static class Client
    {
        public static void Index()
        {
            Animal a = new Animal();
            Animal d = new Dog();
            Animal c = new Cat();
            Executor exe = new Executor();
            a.accept(exe); // 第一次分派
            d.accept(exe); // 第一次分派
            c.accept(exe); // 第一次分派
        }
    }
}

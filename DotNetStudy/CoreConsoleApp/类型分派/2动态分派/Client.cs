/**
 * @file   : Client.cs
 * @date   : 2024/8/1 20:05:05
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.类型分派.动态分派
{
    public static class Client
    {
        public static void Index()
        {
            Animal a = new Animal();
            a.Execute(); //animal

            Animal d = new Dog();
            d.Execute();//dog

            Animal c = new Cat();
            c.Execute();//cat
        }
    }
}

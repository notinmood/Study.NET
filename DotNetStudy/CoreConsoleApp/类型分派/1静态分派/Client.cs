

using System;

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
            使用基类型声明变量();
            使用接口声明变量();
        }

        private static void 使用基类型声明变量()
        {
            Console.WriteLine("使用基类型声明变量,进行分派的演示");
            Animal a = new Animal();
            Animal d = new Dog();
            Animal c = new Cat();
            Executor exe = new Executor();
            exe.execute(a); // animal
            exe.execute(d); // animal
            exe.execute(c); // animal
        }


        private static void 使用接口声明变量()
        {
            Console.WriteLine("使用接口声明变量,进行分派的演示");
            IMove a = new Animal();
            IMove d = new Dog();
            IMove c = new Cat();
            Executor exe = new Executor();
            exe.execute(a); // animal
            exe.execute(d); // animal
            exe.execute(c); // animal
        }
    }
}

using System;
using System.Reflection;
using CoreConsoleApp.设计模式.Factory工厂模式.Biz;

namespace CoreConsoleApp.设计模式.Factory工厂模式.ReflectFactory反射工厂
{
    internal class ReflectFactory
    {
        public static Enemy Create(string name, int width)
        {
            string classFullName = "CoreConsoleApp.设计模式.Factory工厂模式.Biz." + name;

            // 获取 Assembly 对象
            Assembly assembly = Assembly.GetExecutingAssembly();

            // 通过 Type 的 FullName 获取 Type 对象
            Type type = assembly.GetType(classFullName);

            Random random = new Random();
            object[] constructorArgs = [random.Next(width), 0];

            // 创建 MyClass 的实例
            Enemy enemy = (Enemy)Activator.CreateInstance(type, constructorArgs);
            return enemy;
        }
    }
}

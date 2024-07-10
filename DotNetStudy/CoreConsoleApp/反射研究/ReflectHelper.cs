/**
 * @file   : ReflectHelper.cs
 * @date   : 2024/7/9 20:32:01
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Reflection;

namespace CoreConsoleApp.反射研究
{
    public class ReflectHelper
    {
        public static object CreateInstance(string classFullName, object[] constructorArgs = null)
        {
            //// 获取 Assembly 对象
            //if (assembly == null)
            //{
            //    assembly = Assembly.GetExecutingAssembly();
            //}

            // 通过 Type 的 FullName 获取 Type 对象
            //Type type = assembly.GetType(classFullName);
            Type type = Type.GetType(classFullName);

            // 创建目标实例
            object entity = Activator.CreateInstance(type, constructorArgs);
            return entity;
        }
    }
}

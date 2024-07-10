/**
 * @file   : ParentProviderCollection.cs
 * @date   : 2024/7/8 17:01:04
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Configuration.Provider;

namespace CoreConsoleApp.设计模式.Provider提供者模式.X.Sample
{
    /// <summary>
    /// 该类用于管理provider的集合
    /// </summary>
    public class ProviderCollection<T> where T : ProviderBase
    {
        Dictionary<string, T> map = new Dictionary<string, T>();

        /// <summary>
        /// 获取指定名称的provider，从集合中获得名称为name的provider
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public T this[string name]
        {
            get { return (T)map[name]; }
        }

        public T DefaultProvider
        {
            get { return (T)map[defaultProviderName]; }
        }

        private string defaultProviderName = "";
        public void SetDefaultProviderName(string value)
        {
            defaultProviderName = value;
        }


        /// <summary>
        /// 重写基类中添加provider到集合的方法
        /// </summary>
        /// <param name="provider"></param>
        public void Add(string name, T provider)
        {
            if (provider == null)
            {
                throw new ArgumentNullException("Provider");
            }

            if (!(provider is LanguageProvider))
            {
                throw new ArgumentException("Invalid provider type", "provider");
            }

            map[name] = provider;
        }
    }
}

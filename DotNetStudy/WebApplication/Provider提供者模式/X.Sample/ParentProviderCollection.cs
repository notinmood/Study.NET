/**
 * @file   : ParentProviderCollection.cs
 * @date   : 2024/7/8 17:01:04
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Configuration.Provider;

namespace CoreConsoleApp.设计模式.Provider提供者模式.X.Sample
{
    /// <summary>
    /// 该类用于管理provider的集合
    /// </summary>
    public class ParentProviderCollection : ProviderCollection
    {
        /// <summary>
        /// 获取指定名称的provider，从几何中获得名称为name的provider
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public new ParentProvider this[string name]
        {
            get { return (ParentProvider)base[name]; }
        }
        /// <summary>
        /// 重写基类中添加provider到集合的方法
        /// </summary>
        /// <param name="provider"></param>
        public override void Add(ProviderBase provider)
        {
            if (provider == null)
            {
                throw new ArgumentNullException("Provider");
            }

            if (!(provider is ParentProvider))
            {
                throw new ArgumentException("Invalid provider type", "provider");
            }

            base.Add(provider);
        }
    }


}

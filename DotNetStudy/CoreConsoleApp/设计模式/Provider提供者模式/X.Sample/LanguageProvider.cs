/**
 * @file   : ParentProvider.cs
 * @date   : 2024/7/8 16:43:37
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Configuration.Provider;

namespace CoreConsoleApp.设计模式.Provider提供者模式.X.Sample
{
    public abstract class LanguageProvider : ProviderBase
    {
        public abstract string ShowData();
    }
}

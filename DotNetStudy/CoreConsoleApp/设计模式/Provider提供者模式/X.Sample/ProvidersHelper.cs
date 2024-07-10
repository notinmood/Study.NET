/**
 * @file   : ProvidersHelper.cs
 * @date   : 2024/7/10 11:49:50
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Configuration;
using System.Configuration.Provider;
using CoreConsoleApp.反射研究;

namespace CoreConsoleApp.设计模式.Provider提供者模式.X.Sample
{
    public class ProvidersHelper
    {
        public static ProviderCollection<T> InstantiateProviders<T>(string sectionName) where T : ProviderBase
        {
            var providers = new ProviderCollection<T>();

            ProviderConfigurationSection providerSection = ConfigurationManager.GetSection(sectionName) as ProviderConfigurationSection;

            if (providerSection != null)
            {
                providers.SetDefaultProviderName(providerSection.DefaultProvider);

                foreach (ProviderSettings providerSetting in providerSection.Providers)
                {
                    try
                    {
                        string providerName = providerSetting.Name;
                        string classFullName = providerSetting.Type;
                        
                        // 解析提供者类型
                        T providerInstance = (T)ReflectHelper.CreateInstance(classFullName);
                        
                        // 可能需要进一步初始化
                        //...

                        // 添加到本地容器中，供后续调用。
                        providers.Add(providerName, providerInstance);
                    }
                    catch (Exception ex)
                    {
                        // 异常处理，例如记录日志
                        // Log.Error("Error instantiating provider", ex);
                    }
                }
            }

            return providers;
        }
    }
}

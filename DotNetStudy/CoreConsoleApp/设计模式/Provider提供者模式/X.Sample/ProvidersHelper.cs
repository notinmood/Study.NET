/**
 * @file   : ProvidersHelper.cs
 * @date   : 2024/7/10 11:49:50
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Provider;
using CoreConsoleApp.反射研究;

namespace CoreConsoleApp.设计模式.Provider提供者模式.X.Sample
{
    internal class ProvidersHelper
    {
        public static List<T> InstantiateProviders<T>(string sectionName) where T : ProviderBase
        {
            var providers = new List<T>();
            var providerConfig = ConfigurationManager.GetSection(sectionName) as ProviderSettingsCollection;

            if (providerConfig != null)
            {
                foreach (ProviderSettings providerSetting in providerConfig)
                {
                    try
                    {
                        string classFullName = providerSetting.Name;
                        // 解析提供者类型
                        var providerInstance = (T)ReflectHelper.CreateInstance(classFullName);
                        // 可能需要进一步初始化
                        providers.Add(providerInstance);
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

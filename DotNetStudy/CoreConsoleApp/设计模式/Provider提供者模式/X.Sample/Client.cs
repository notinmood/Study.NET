/**
 * @file   : Client.cs
 * @date   : 2024/7/8 17:07:07
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.Provider提供者模式.X.Sample
{
    internal class Client
    {
        private LanguageProvider provider;
        private LanguageProviderCollection providerCollection;

        public static void Index()
        {
            Console.WriteLine(LoadProvider());
        }

        private static object LoadProvider(string providerSelected = "")
        {
            //LanguageProviderConfigurationSection config = null;
            //config = (LanguageProviderConfigurationSection)ConfigurationManager.GetSection("LanguageProvider");
            List<LanguageProvider> list = ProvidersHelper.InstantiateProviders<LanguageProvider>("LanguageProvider");
            //provider = providerCollection[providerSelected ?? config.DefaultProvider];
            return list;
        }
    }
}

/**
 * @file   : Client.cs
 * @date   : 2024/7/8 17:07:07
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Provider提供者模式.X.Sample
{
    internal class Client
    {
        private static LanguageProvider provider;
        private static ProviderCollection<LanguageProvider> providerCollection;

        public static void Index()
        {
            LanguageProvider provider = LoadProvider();
            Console.WriteLine(provider.ShowData());
        }

        private static LanguageProvider LoadProvider(string providerSelected = "")
        {
            providerCollection = ProvidersHelper.InstantiateProviders<LanguageProvider>("LanguageProvider");

            if (providerSelected == "")
            {
                return providerCollection.DefaultProvider;
            }

            provider = providerCollection[providerSelected];
            return provider;
        }
    }
}

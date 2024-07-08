/**
 * @file   : Client.cs
 * @date   : 2024/7/8 17:07:07
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Configuration;
using System.Web.Configuration;



namespace CoreConsoleApp.设计模式.Provider提供者模式.X.Sample
{
    internal class Client
    {
        private ParentProvider provider;
        private ParentProviderCollection providerCollection;

        private void LoadProvider(string providerSelected)
        {
            ParentProviderConfigurationSection config = null;
            config = (ParentProviderConfigurationSection)ConfigurationManager.GetSection("parentProvider");
            providerCollection = new ParentProviderCollection();
            ProvidersHelper.InstantiateProviders(config.Providers, providerCollection, typeof(ParentProvider));
            provider = providerCollection[providerSelected ?? config.DefaultProvider];
        }
    }
}

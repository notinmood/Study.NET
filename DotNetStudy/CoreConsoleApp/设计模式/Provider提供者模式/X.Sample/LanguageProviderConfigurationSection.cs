/**
 * @file   : ParentProviderConfigurationSection.cs
 * @date   : 2024/7/8 17:02:40
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Configuration;

namespace CoreConsoleApp.设计模式.Provider提供者模式.X.Sample
{
    /// <summary>
    /// 这个类可以看成是一个管理配置文件中节点的类，
    /// 这个类中属性使用Attribute的方式声明值，具体里面的值可以通过反射得到
    /// </summary>
    public class LanguageProviderConfigurationSection : ConfigurationSection
    {
        /// <summary>
        /// 获取配置文件中配置节名称为Providers的信息
        /// </summary>
        [ConfigurationProperty("providers")]
        public ProviderSettingsCollection Providers
        {
            get { return (ProviderSettingsCollection)base["providers"]; }
        }
        
        //[StringValidator(MinLength=1)]
        [ConfigurationProperty("defaultProvider")]
        public string DefaultProvider
        {
            get { return (string)base["defaultProvider"]; }
            set { base["defaultProvider"] = value; }
        }
    }

}

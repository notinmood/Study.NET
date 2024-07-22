/**
 * @file   : ElementInfo.cs
 * @date   : 2024/7/22 11:56:00
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Configuration;

namespace CoreConsoleApp.配置文件中自定义内容.带分组的Section
{
    internal class ElementInfo : ConfigurationElement
    {
        public ElementInfo() { }


        [ConfigurationProperty("element1", DefaultValue = "element1", IsRequired = true)]
        public string Element1
        {
            get { return (string)this["element1"]; }
        }

        [ConfigurationProperty("element2", DefaultValue = "element2", IsRequired = true)]
        public string Element2
        {
            get { return (string)this["element2"]; }
        }
    }
}

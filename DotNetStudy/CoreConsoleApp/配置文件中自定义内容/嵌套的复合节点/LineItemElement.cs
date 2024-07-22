/**
 * @file   : LineItemElement.cs
 * @date   : 2024/7/22 11:13:59
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Configuration;

namespace CoreConsoleApp.配置文件中自定义内容.嵌套的复合节点
{
    internal class LineItemElement : ConfigurationElement
    {
        [ConfigurationProperty("number", IsKey = true, IsRequired = true)]
        public string Number
        {
            get
            {
                return (string)base["number"];
            }
            set
            {
                base["number"] = value;
            }
        }

        [ConfigurationProperty("description", IsRequired = true)]
        public string Description
        {
            get
            {
                return (string)base["description"];
            }
            set
            {
                base["description"] = value;
            }
        }
    }
}

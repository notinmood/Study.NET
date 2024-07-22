/**
 * @file   : OrdersSection.cs
 * @date   : 2024/7/22 11:10:57
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Configuration;

namespace CoreConsoleApp.配置文件中自定义内容.嵌套的复合节点
{
    internal class OrdersSection : ConfigurationSection
    {
        [ConfigurationProperty("companyID", IsRequired = true)]
        public string CompanyID
        {
            get
            {
                return (string)base["companyID"];
            }
            set
            {
                base["companyID"] = value;
            }
        }

        //因为orders节点和section节点是一个，所以此处不能设置对应的节点名称
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public OrderElementCollection Orders
        {
            get
            {
                return (OrderElementCollection)base[""];
            }
        }
    }
}

/**
 * @file   : OrderElement.cs
 * @date   : 2024/7/22 11:12:46
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.配置文件中自定义内容.嵌套的复合节点
{
    internal class OrderElement : ConfigurationElement
    {
        [ConfigurationProperty("number", IsRequired = true)]
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

        [ConfigurationProperty("amount", IsRequired = true)]
        public double Amount
        {
            get
            {
                return (double)base["amount"];
            }
            set
            {
                base["amount"] = value;
            }
        }

        [ConfigurationProperty("lineItems", IsDefaultCollection = true)]
        public LineItemElementCollection LineItems
        {
            get
            {
                return (LineItemElementCollection)base["lineItems"];
            }
        }
    }
}

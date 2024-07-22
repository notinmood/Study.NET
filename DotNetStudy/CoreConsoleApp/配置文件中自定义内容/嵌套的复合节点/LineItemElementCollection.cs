/**
 * @file   : LineItemElementCollection.cs
 * @date   : 2024/7/22 11:13:27
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
    internal class LineItemElementCollection : ConfigurationElementCollection
    {
        [ConfigurationProperty("warehouseNumber", IsRequired = true)]
        public string WarehouseNumber
        {
            get
            {
                return (string)base["warehouseNumber"];
            }
            set
            {
                base["warehouseNumber"] = value;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new LineItemElement();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((LineItemElement)element).Number;
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }
        protected override string ElementName
        {
            get
            {
                return "lineItem";
            }
        }

        public LineItemElement this[int index]
        {
            get
            {
                return (LineItemElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }
    }
}

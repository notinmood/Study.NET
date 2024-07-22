/**
 * @file   : MyCustomSection.cs
 * @date   : 2024/7/10 17:46:04
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Configuration;

namespace CoreConsoleApp.配置文件中自定义内容.最简方式
{
    public class MySimpleSection : ConfigurationSection
    {
        //非常重要的特性声明。用此种语法将本地的属性和配置文件中的节点对照上。
        //即将本地的属性MySetting和配置文件中的节点`MySimpleSection/mySetting`对照上。
        [ConfigurationProperty("mySetting", IsRequired = true)]
        public string MySetting
        {
            get { return (string)this["mySetting"]; }
            set { this["mySetting"] = value; }
        }

        // 可以添加更多的配置属性
    }

}
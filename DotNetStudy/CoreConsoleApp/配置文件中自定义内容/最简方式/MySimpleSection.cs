/**
 * @file   : MyCustomSection.cs
 * @date   : 2024/7/10 17:46:04
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Configuration;

namespace CoreConsoleApp.配置文件中自定义内容.最简方式
{
    public class MySimpleSection : ConfigurationSection
    {
        [ConfigurationProperty("mySetting", IsRequired = true)]
        public string MySetting
        {
            get { return (string)this["mySetting"]; }
            set { this["mySetting"] = value; }
        }

        // 可以添加更多的配置属性
    }

}
/**
 * @file   : MyGroupedSection.cs
 * @date   : 2024/7/22 11:51:30
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.配置文件中自定义内容.带分组的Section
{
    internal class MyGroupedSection : ConfigurationSection
    {
        public MyGroupedSection()
        {
            //some thing;
        }

        [ConfigurationProperty("user", DefaultValue = "yanghong", IsRequired = true)]
        public string User
        {
            get { return (string)this["user"]; }
            set { this["user"] = value; }
        }

        [ConfigurationProperty("password", DefaultValue = "password", IsRequired = true)]
        public string PassWord
        {
            get { return (string)this["password"]; }
            set { this["password"] = value; }
        }

        [ConfigurationProperty("element")]
        public ElementInfo Element
        {
            get { return (ElementInfo)this["element"]; }
            set { this["element"] = value; }
        }
    }
}

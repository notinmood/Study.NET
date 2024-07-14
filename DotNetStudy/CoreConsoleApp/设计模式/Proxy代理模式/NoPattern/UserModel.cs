/**
 * @file   : UserModel.cs
 * @date   : 2024/7/13 23:13:56
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.Proxy代理模式.NoPattern
{
    /**
  * 描述用户数据的对象
  */
    public class UserModel
    {
        /**
         * 用户编号
         */
        private String userId;
        /**
         * 用户姓名
         */
        private String name;
        /**
         * 部门编号
         */
        private String depId;
        /**
         * 性别
         */
        private String sex;

        public String getUserId()
        {
            return userId;
        }
        public void setUserId(String userId)
        {
            this.userId = userId;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getDepId()
        {
            return depId;
        }
        public void setDepId(String depId)
        {
            this.depId = depId;
        }
        public String getSex()
        {
            return sex;
        }
        public void setSex(String sex)
        {
            this.sex = sex;
        }
        public String ToString()
        {
            return "userId=" + userId + ",name=" + name + ",depId=" + depId + ",sex=" + sex + "\n";
        }
    }

}

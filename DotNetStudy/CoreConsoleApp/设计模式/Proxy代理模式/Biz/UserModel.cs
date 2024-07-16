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

namespace CoreConsoleApp.设计模式.Proxy代理模式.Biz
{
    /**
  * 描述用户数据的对象
  */
    public class UserModel
    {
        /**
         * 用户编号
         */
        private string userId;
        /**
         * 用户姓名
         */
        private string name;
        /**
         * 部门编号
         */
        private string depId;
        /**
         * 性别
         */
        private string sex;

        public string GetUserId()
        {
            return userId;
        }
        public void SetUserId(string userId)
        {
            this.userId = userId;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetDepId()
        {
            return depId;
        }
        public void SetDepId(string depId)
        {
            this.depId = depId;
        }
        public string GetSex()
        {
            return sex;
        }
        public void SetSex(string sex)
        {
            this.sex = sex;
        }
        public override string ToString()
        {
            return "userId=" + userId + ",name=" + name + ",depId=" + depId + ",sex=" + sex + "\n";
        }
    }

}

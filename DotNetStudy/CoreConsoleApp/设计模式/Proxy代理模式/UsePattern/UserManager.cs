/**
 * @file   : UserManager.cs
 * @date   : 2024/7/28 9:44:14
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CoreConsoleApp.设计模式.Proxy代理模式.Biz;

namespace CoreConsoleApp.设计模式.Proxy代理模式.UsePattern
{
    /**
   * 实现示例要求的功能
   */
    public class UserManager
    {
        /**
         * 根据部门编号来获取该部门下的所有人员
         * @param depId 部门编号
         * @return 该部门下的所有人员
         */
        public IList<IUserModel> GetUserByDepId(String depId)
        {
            IList<UserModel> collection = Db.UsersInDB.Where(s => s.GetDepId().StartsWith(depId)).ToList();
            var result = new List<IUserModel>();
            foreach (var item in collection)
            {
                result.Add(new Proxy(item));
            }

            return result;
        }
    }

}

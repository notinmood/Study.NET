/**
 * @file   : UserManager.cs
 * @date   : 2024/7/13 23:15:00
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Collections.Generic;
using System.Linq;
using CoreConsoleApp.设计模式.Proxy代理模式.Biz;

namespace CoreConsoleApp.设计模式.Proxy代理模式.NoPattern
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
        public List<UserModel> getUserByDepId(string depId)
        {
            List<UserModel> col = Db.UsersInDB.Where(s => s.GetDepId().StartsWith(depId)).ToList();
            return col;
        }
    }

}

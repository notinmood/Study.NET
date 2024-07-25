/**
 * @file   : DepUserModel.cs
 * @date   : 2024/7/25 11:09:23
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.Mediator中介者模式.X.部门人员关系的处理
{
    /**
 *  描述部门和人员关系的类
 */
    public class DepUserModel
    {
        /**
         * 用于部门和人员关系的编号，用做主键
         */
        public string DepUserId { get; set; }

        /**
         * 部门的编号
         */
        public string DepId { get; set; }

        /**
         * 人员的编号
         */
        public string UserId { get; set; }
    }

}

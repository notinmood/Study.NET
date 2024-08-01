/**
 * @file   : Dep.cs
 * @date   : 2024/7/25 11:08:11
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Mediator中介者模式.X.部门人员关系的处理
{
    /**
 * 部门类
 */
    public class Dep
    {
        /**
         * 描述部门编号
         */
        private string depId;
        /**
         * 描述部门名称
         */
        private string depName;

        public string getDepId()
        {
            return depId;
        }
        public void setDepId(string depId)
        {
            this.depId = depId;
        }
        public string getDepName()
        {
            return depName;
        }
        public void setDepName(string depName)
        {
            this.depName = depName;
        }
        /**
         * 撤销部门
         * @return 是否撤销成功
         */
        public bool deleteDep()
        {
            //1：要先通过中介者去清除掉所有与这个部门相关的部门和人员的关系
            DepUserMediatorImpl mediator = DepUserMediatorImpl.getInstance();
            mediator.DeleteDep(depId);
            //2：然后才能真的清除掉这个部门
            //请注意在实际开发中，这些业务功能可能会做到业务层去，
            //而且实际开发中对于已经使用的业务数据通常是不会被删除的，
            //而是会被做为历史数据保留
            return true;
        }
    }

}

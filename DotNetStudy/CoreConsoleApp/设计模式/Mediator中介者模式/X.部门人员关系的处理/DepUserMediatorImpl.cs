/**
 * @file   : DepUserMediatorImpl.cs
 * @date   : 2024/7/25 11:10:04
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.Mediator中介者模式.X.部门人员关系的处理
{
    /**
 * 实现部门和人员交互的中介者实现类
 * 说明：为了演示的简洁性，只示例实现撤销部门和人员离职的功能
 */
    public class DepUserMediatorImpl
    {
        private static DepUserMediatorImpl mediator = new DepUserMediatorImpl();
        private DepUserMediatorImpl()
        {
            //调用初始化测试数据的功能
            initTestData();
        }
        public static DepUserMediatorImpl getInstance()
        {
            return mediator;
        }

        /**
         * 测试用，记录部门和人员的关系
         */
        private readonly List<DepUserModel> depUserCol = new List<DepUserModel>();

        /**
         * 初始化测试数据
         */
        private void initTestData()
        {
            //准备一些测试数据
            DepUserModel du1 = new DepUserModel { DepUserId = "du1", DepId = "d1", UserId = "u1" };
            depUserCol.Add(du1);

            DepUserModel du2 = new DepUserModel { DepUserId = "du2", DepId = "d1", UserId = "u2" };
            depUserCol.Add(du2);

            DepUserModel du3 = new DepUserModel { DepUserId = "du3", DepId = "d2", UserId = "u3" };
            depUserCol.Add(du3);

            DepUserModel du4 = new DepUserModel { DepUserId = "du4", DepId = "d2", UserId = "u4" };
            depUserCol.Add(du4);

            DepUserModel du5 = new DepUserModel { DepUserId = "du5", DepId = "d2", UserId = "u1" };
            depUserCol.Add(du5);
        }
        /**
         * 完成因撤销部门的操作所引起的与人员的交互，需要去除相应的关系
         * @param depId 被撤销的部门对象的编号
         * @return 是否已经正确的处理了因撤销部门所引起的与人员的交互
         */
        public bool deleteDep(string depId)
        {
            //请注意：为了演示简单，部门撤销后，
            //原部门的人员怎么处理等后续业务处理，这里就不管了
            depUserCol.RemoveAll(x => x.DepId == depId);
            return true;
        }
        /**
         * 完成因人员离职引起的与部门的交互
         * @param userId 离职的人员的编号
         * @return 是否正确处理了因人员离职引起的与部门的交互
         */
        public bool deleteUser(string userId)
        {
            depUserCol.RemoveAll(x => x.UserId == userId);
            return true;
        }
        /**
         * 测试用，在内部打印显示一下一个部门下的所有人员
         * @param dep 部门对象
         */
        public void showDepUsers(Dep dep)
        {
            foreach (DepUserModel du in depUserCol)
            {
                if (du.DepId == dep.getDepId())
                {
                    Console.WriteLine("部门编号=" + dep.getDepId() + "下面拥有人员，其编号是：" + du.UserId);
                }
            }
        }
        /**
         * 测试用，在内部打印显示一下一个人员所属的部门
         * @param user 人员对象
         */
        public void showUserDeps(User user)
        {
            foreach (DepUserModel du in depUserCol)
            {
                if (du.UserId == user.getUserId())
                {
                    Console.WriteLine("人员编号=" + user.getUserId() + "属于部门编号是：" + du.DepId);
                }
            }
        }
        /**
         * 完成因人员调换部门引起的与部门的交互
         * @param userId 被调换的人员的编号
         * @param oldDepId 调换前的部门的编号
         * @param newDepId 调换后的部门的编号
         * @return 是否正确处理了因人员调换部门引起的与部门的交互
         */
        public bool changeDep(string userId, string oldDepId, string newDepId)
        {
            //本示例不去实现了
            return false;
        }
        /**
         * 完成因部门合并操作所引起的与人员的交互
         * @param colDepIds 需要合并的部门的编号集合
         * @param newDep 合并后新的部门对象
         * @return 是否正确处理了因部门合并操作所引起的与人员的交互
         */
        public bool joinDep(List<String> colDepIds, Dep newDep)
        {
            //本示例不去实现了     
            return false;
        }
    }

}

/**
 * @file   : Db.cs
 * @date   : 2024/7/13 23:18:44
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.Proxy代理模式.Biz
{
    /// <summary>
    /// 模拟存储数据的数据库
    /// </summary>
    internal static class Db
    {
        readonly static List<UserModel> usersInDB = new List<UserModel>();
        readonly static List<DepModel> depsInDB = new List<DepModel>();

        static Db()
        {
            usersInDB.Add(new UserModel("user0001", "张三", "010101", "男"));
            usersInDB.Add(new UserModel("user0002", "李四", "010101", "男"));
            usersInDB.Add(new UserModel("user0003", "王五", "010102", "男"));
            usersInDB.Add(new UserModel("user0004", "赵六", "010201", "男"));
            usersInDB.Add(new UserModel("user0005", "姜七", "010201", "男"));
            usersInDB.Add(new UserModel("user0006", "牛八", "010202", "男"));

            depsInDB.Add(new DepModel("01", "总公司", "这是 总公司"));
            depsInDB.Add(new DepModel("0101", "一分公司", "这是 一分公司"));
            depsInDB.Add(new DepModel("0102", "二分公司", "这是 二分公司"));
            depsInDB.Add(new DepModel("010101", "开发部", "这是 开发部"));
            depsInDB.Add(new DepModel("010102", "测试部", "这是 测试部"));
            depsInDB.Add(new DepModel("010201", "开发部(II)", "这是 开发部(II)"));
            depsInDB.Add(new DepModel("010202", "客服部", "这是 客服部"));
        }


        public static List<UserModel> UsersInDB { get { return usersInDB; } }
        public static List<DepModel> DepsInDB { get { return depsInDB; } }

    }
}

/**
 * @file   : UserManager.cs
 * @date   : 2024/7/13 23:15:00
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;

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
        public List<UserModel> getUserByDepId(String depId)
        {
            List<UserModel> col = new List<UserModel>();
            //Connection conn = null;
            //try
            //{
            //    conn = this.getConnection();
            //    String sql = "select * from tbl_user u,tbl_dep d "
            //                 + "where u.depId=d.depId and d.depId like ?";

            //    PreparedStatement pstmt = conn.prepareStatement(sql);
            //    pstmt.setString(1, depId + "%");

            //    ResultSet rs = pstmt.executeQuery();
            //    while (rs.next())
            //    {
            //        UserModel um = new UserModel();
            //        um.setUserId(rs.getString("userId"));
            //        um.setName(rs.getString("name"));
            //        um.setDepId(rs.getString("depId"));
            //        um.setSex(rs.getString("sex"));

            //        col.add(um);
            //    }
            //    rs.close();
            //    pstmt.close();
            //}
            //finally
            //{
            //    conn.close();
            //}
            return col;
        }
        /**
         * 获取与数据库的连接
         * @return 数据库连接
         */
        //        private Connection getConnection() throws Exception
        //        {
        //            Class.forName("你用的数据库对应的JDBC驱动类");
        //       return DriverManager.getConnection("连接数据库的URL", "用户名", "密码");
        //}
    }

}

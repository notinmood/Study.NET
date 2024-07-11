/**
 * @file   : TempDB.cs
 * @date   : 2024/7/11 17:01:23
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.Decorator装饰者.Biz
{
    /** 
   * 在内存中模拟数据库，准备点测试数据，好计算奖金 
   */
    public class TempDB
    {
        private TempDB()
        {
        }
        /** 
         * 记录每个人的月度销售额，只用了人员，月份没有用 
         */
        public static Dictionary<String, Double> mapMonthSaleMoney = new Dictionary<String, Double>();

        static TempDB()
        {
            //填充测试数据  
            mapMonthSaleMoney.Add("张三", 10000.0);
            mapMonthSaleMoney.Add("李四", 20000.0);
            mapMonthSaleMoney.Add("王五", 30000.0);
        }
    }
}
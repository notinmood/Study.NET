/**
 * @file   : LogDbOperateApi.cs
 * @date   : 2024/8/7 7:50:26
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Collections.Generic;
using CoreConsoleApp.设计模式.Adapter适配器.Biz;

namespace CoreConsoleApp.设计模式.Adapter适配器.NoPattern.V2.UseDbLog
{
    /**
   * 定义操作日志的应用接口，为了示例的简单，只是简单的定义了增删改查的方法
   */
    public interface ILogDbOperate
    {
        /**
         * 新增日志
         * @param lm 需要新增的日志对象
         */
        public void createLog(LogModel lm);
        /**
         * 修改日志
         * @param lm 需要修改的日志对象
         */
        public void updateLog(LogModel lm);
        /**
         * 删除日志
         * @param lm 需要删除的日志对象
         */
        public void removeLog(LogModel lm);
        /**
         * 获取所有的日志
         * @return 所有的日志对象
         */
        public List<LogModel> getAllLog();
    }
}

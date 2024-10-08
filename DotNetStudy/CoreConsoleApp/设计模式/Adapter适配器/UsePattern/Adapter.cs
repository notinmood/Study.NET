﻿/**
 * @file   : Adapter.cs
 * @date   : 2024/8/7 7:57:10
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Collections.Generic;
using System.Linq;
using CoreConsoleApp.设计模式.Adapter适配器.Biz;
using CoreConsoleApp.设计模式.Adapter适配器.NoPattern.V1.UseFileLog;
using CoreConsoleApp.设计模式.Adapter适配器.NoPattern.V2.UseDbLog;

namespace CoreConsoleApp.设计模式.Adapter适配器.UsePattern
{
    /**
     * 适配器对象，把记录日志到文件的功能适配成第二版需要的增删改查的功能
     */
    public class Adapter : ILogDbOperate
    {
        /**
         * 持有需要被适配的接口对象
         */
        private readonly ILogFileOperate adaptee;
        /**
         * 构造方法，传入需要被适配的对象
         * @param adaptee 需要被适配的对象
         */
        public Adapter(ILogFileOperate adaptee)
        {
            this.adaptee = adaptee;
        }

        public void createLog(LogModel lm)
        {
            //1：先读取文件的内容
            List<LogModel> list = adaptee.readLogFile();
            //2：加入新的日志对象
            list.Add(lm);
            //3：重新写入文件
            adaptee.writeLogFile(list);
        }
        public List<LogModel> getAllLog()
        {
            return adaptee.readLogFile();
        }
        public void removeLog(LogModel lm)
        {
            //1：先读取文件的内容
            List<LogModel> list = adaptee.readLogFile();
            //2：删除相应的日志对象
            list.Remove(lm);
            //3：重新写入文件
            adaptee.writeLogFile(list);
        }
        public void updateLog(LogModel lm)
        {
            //1：先读取文件的内容
            List<LogModel> list = adaptee.readLogFile();
            //2：修改相应的日志对象
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAtOrDefault(i).getLogId() == lm.getLogId())
                {
                    list[i] = lm;
                    break;
                }
            }
            //3：重新写入文件
            adaptee.writeLogFile(list);
        }
    }
}

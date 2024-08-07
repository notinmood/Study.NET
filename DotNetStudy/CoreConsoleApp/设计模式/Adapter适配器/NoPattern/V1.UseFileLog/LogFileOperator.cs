/**
 * @file   : LogFileOperate.cs
 * @date   : 2024/8/7 7:38:43
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.IO;
using CoreConsoleApp.设计模式.Adapter适配器.Biz;

namespace CoreConsoleApp.设计模式.Adapter适配器.NoPattern.V1.UseFileLog
{
    /**
   * 实现对日志文件的操作
   */
    public class LogFileOperator : ILogFileOperate
    {
        /**
         * 日志文件的路径和文件名称，默认是当前项目的根下的AdapterLog.log
         */
        private readonly String logFilePathName = "AdapterLog.log";
        /**
         * 构造方法，传入文件的路径和名称
         * @param logFilePathName 文件的路径和名称
         */
        public LogFileOperator(String logFilePathName)
        {
            //先判断是否传入了文件的路径和名称，如果是，
            //就重新设置操作的日志文件的路径和名称
            if (logFilePathName != null && logFilePathName.Trim().Length > 0)
            {
                this.logFilePathName = logFilePathName;
            }
        }
        public List<LogModel> readLogFile()
        {
            return new List<LogModel>();

            //List<LogModel> list = null;
            //ObjectInputStream oin = null;
            //try
            //{
            //    File f = new File(logFilePathName);
            //    if (f.exists())
            //    {
            //        oin = new ObjectInputStream(new BufferedInputStream(new FileInputStream(f)));
            //        list = (List<LogModel>)oin.readObject();
            //    }
            //}
            //catch (Exception e)
            //{
            //    e.printStackTrace();
            //}
            //finally
            //{
            //    try
            //    {
            //        if (oin != null)
            //        {
            //            oin.close();
            //        }
            //    }
            //    catch (IOException e)
            //    {
            //        e.printStackTrace();
            //    }
            //}
            //return list;
        }
        public void writeLogFile(List<LogModel> list)
        {
            //TODO:xiedali@2024/08/07 写入文件

            //File f = new File(logFilePathName);
            //ObjectOutputStream oout = null;
            //try
            //{
            //    oout = new ObjectOutputStream(new BufferedOutputStream(new FileOutputStream(f)));
            //    oout.writeObject(list);
            //}
            //catch (IOException e)
            //{
            //    e.printStackTrace();
            //}
            //finally
            //{
            //    try
            //    {
            //        oout.close();
            //    }
            //    catch (IOException e)
            //    {
            //        e.printStackTrace();
            //    }
            //}
        }
    }

}

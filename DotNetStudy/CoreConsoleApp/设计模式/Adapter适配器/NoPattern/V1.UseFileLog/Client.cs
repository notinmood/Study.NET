/**
 * @file   : Client.cs
 * @date   : 2024/8/7 7:45:53
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using CoreConsoleApp.设计模式.Adapter适配器.Biz;

namespace CoreConsoleApp.设计模式.Adapter适配器.NoPattern.V1.UseFileLog
{
    public static class Client
    {
        public static void Index()
        {
            //准备日志内容，也就是测试的数据
            LogModel lm1 = new LogModel();
            lm1.setLogId("001");
            lm1.setOperateUser("admin");
            lm1.setOperateTime("2010-03-0210:08:18");
            lm1.setLogContent("这是一个测试");

            List<LogModel> list = new List<LogModel>();
            list.Add(lm1);
            //创建操作日志文件的对象
            ILogFileOperate api = new LogFileOperator("");
            //保存日志文件
            api.writeLogFile(list);

            //读取日志文件的内容
            List<LogModel> readLog = api.readLogFile();
            Console.WriteLine("readLog=" + readLog);
        }
    }

}

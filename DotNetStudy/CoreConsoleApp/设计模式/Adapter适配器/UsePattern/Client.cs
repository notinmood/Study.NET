/**
 * @file   : Client.cs
 * @date   : 2024/8/7 8:05:17
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using CoreConsoleApp.设计模式.Adapter适配器.Biz;
using CoreConsoleApp.设计模式.Adapter适配器.NoPattern.V1.UseFileLog;
using CoreConsoleApp.设计模式.Adapter适配器.NoPattern.V2.UseDbLog;

namespace CoreConsoleApp.设计模式.Adapter适配器.UsePattern
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

            //创建操作日志文件的对象
            ILogFileOperate logFileApi = new LogFileOperator("");

            //创建新版的操作日志的接口对象
            ILogDbOperate api = new Adapter(logFileApi);

            //保存日志文件
            api.createLog(lm1);
            //读取日志文件的内容
            List<LogModel> allLog = api.getAllLog();
            Console.WriteLine("allLog=" + allLog);
        }
    }

}

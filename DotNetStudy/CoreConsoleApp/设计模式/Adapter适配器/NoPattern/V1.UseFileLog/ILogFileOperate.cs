/**
 * @file   : LogFileOperateApi.cs
 * @date   : 2024/8/7 7:38:03
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreConsoleApp.设计模式.Adapter适配器.Biz;

namespace CoreConsoleApp.设计模式.Adapter适配器.NoPattern.V1.UseFileLog
{
    /**
   * 日志文件操作接口
   */
    public interface ILogFileOperate
    {
        /**
         * 读取日志文件，从文件里面获取存储的日志列表对象
         * @return 存储的日志列表对象
         */
        public List<LogModel> readLogFile();
        /**
         * 写日志文件，把日志列表写出到日志文件中去
         * @param list 要写到日志文件的日志列表
         */
        public void writeLogFile(List<LogModel> list);
    }

}

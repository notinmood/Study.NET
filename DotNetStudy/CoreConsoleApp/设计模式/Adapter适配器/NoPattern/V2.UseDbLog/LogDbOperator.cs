/**
 * @file   : LogDbOperator.cs
 * @date   : 2024/8/7 9:40:01
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

namespace CoreConsoleApp.设计模式.Adapter适配器.NoPattern.V2.UseDbLog
{
    internal class LogDbOperator : ILogDbOperate
    {
        public void createLog(LogModel lm)
        {
            throw new NotImplementedException();
        }

        public List<LogModel> getAllLog()
        {
            throw new NotImplementedException();
        }

        public void removeLog(LogModel lm)
        {
            throw new NotImplementedException();
        }

        public void updateLog(LogModel lm)
        {
            throw new NotImplementedException();
        }
    }
}

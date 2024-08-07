/**
 * @file   : LogModel.cs
 * @date   : 2024/8/7 7:36:16
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Adapter适配器.Biz
{
    /**
   * 日志数据对象
   */
    public class LogModel
    {
        /**
         * 日志编号
         */
        private string logId;
        /**
         * 操作人员
         */
        private string operateUser;
        /**
         * 操作时间，以yyyy-MM-dd HH:mm:ss的格式记录
         */
        private string operateTime;
        /**
         * 日志内容
         */
        private string logContent;

        public string getLogId()
        {
            return logId;
        }
        public void setLogId(string logId)
        {
            this.logId = logId;
        }
        public string getOperateUser()
        {
            return operateUser;
        }
        public void setOperateUser(string operateUser)
        {
            this.operateUser = operateUser;
        }
        public string getOperateTime()
        {
            return operateTime;
        }
        public void setOperateTime(string operateTime)
        {
            this.operateTime = operateTime;
        }
        public string getLogContent()
        {
            return logContent;
        }
        public void setLogContent(string logContent)
        {
            this.logContent = logContent;
        }
        public string toString()
        {
            return "logId=" + logId + ",operateUser=" + operateUser + ",operateTime=" + operateTime + ",logContent=" + logContent;
        }
    }
}

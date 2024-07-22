/**
 * @file   : LeaveRequestModel.cs
 * @date   : 2024/7/7 10:21:09
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.X.请假流程的示例
{
    public class LeaveRequestModel
    {
        /**
         * 请假人
         */
        private string user;
        /**
         * 请假开始时间
         */
        private string beginDate;
        /**
         * 请假天数
         */
        private int leaveDays;
        /**
         * 审核结果
         */
        private string result;

        public string GetResult()
        {
            return result;
        }
        public void SetResult(string result)
        {
            this.result = result;
        }
        public string GetUser()
        {
            return user;
        }
        public string GetBeginDate()
        {
            return beginDate;
        }
        public int GetLeaveDays()
        {
            return leaveDays;
        }
        public void setUser(string user)
        {
            this.user = user;
        }
        public void SetBeginDate(string beginDate)
        {
            this.beginDate = beginDate;
        }
        public void SetLeaveDays(int leaveDays)
        {
            this.leaveDays = leaveDays;
        }
    }

}

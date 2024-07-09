/**
 * @file   : FeeRequestModel.cs
 * @date   : 2024/7/9 15:32:02
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter
{
    /**
 * 封装跟聚餐费用申请业务相关的请求数据
 */
    public class FeeRequestModel : RequestModel
    {
        /**
         * 约定具体的业务类型
         */
        public static string FEE_TYPE = "Fee";
        public FeeRequestModel(string user ,double fee) : base(FEE_TYPE)
        {
            this.user= user;
            this.fee= fee;
        }
        /**
         * 申请人
         */
        private String user;
        /**
         * 申请金额
         */
        private double fee;
        public String getUser()
        {
            return user;
        }
        public void setUser(String user)
        {
            this.user = user;
        }
        public double getFee()
        {
            return fee;
        }
        public void setFee(double fee)
        {
            this.fee = fee;
        }
    }

}

﻿/**
 * @file   : Handler.cs
 * @date   : 2024/7/9 7:49:40
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePattern
{
    /**
     * 定义职责对象的接口
     */
    public abstract class Handler
    {
        /**
         * 持有下一个处理请求的对象
         */
        protected Handler successor = null;
        /**
         * 设置下一个处理请求的对象
         * @param successor 下一个处理请求的对象
         */
        public void setSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        /**
         * 处理聚餐费用的申请
         * @param user 申请人
         * @param fee 申请的钱数
         * @return 成功或失败的具体通知
         */
        public abstract String handleFeeRequest(String user, double fee);
    }


}

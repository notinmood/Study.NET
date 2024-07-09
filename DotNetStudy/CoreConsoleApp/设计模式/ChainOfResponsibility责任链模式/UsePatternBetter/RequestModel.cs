/**
 * @file   : RequestModel.cs
 * @date   : 2024/7/9 15:30:38
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter
{
    /**
  * 通用的请求对象
  */
    public class RequestModel
    {
        /**
         * 表示具体的业务类型
         */
        private String type;
        /**
         * 通过构造方法把具体的业务类型传递进来
         * @param type 具体的业务类型
         */
        public RequestModel(String type)
        {
            this.type = type;
        }
        public String getType()
        {
            return type;
        }
    }

}

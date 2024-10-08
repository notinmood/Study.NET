﻿/**
 * @file   : Handler.cs
 * @date   : 2024/7/9 15:31:15
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using CoreConsoleApp.反射研究;
using System.Reflection;

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter
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
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public Handler GetSuccessor()
        {
            return this.successor;
        }

        /**
         * 通用的请求处理方法
         * @param rm 通用的请求对象
         * @return 处理后需要返回的对象
         */
        public virtual object HandleRequest(RequestModel model)
        {
            if (successor != null)
            {
                //这个是默认的实现，如果子类不愿意处理这个请求，
                //那就传递到下一个职责对象去处理
                return this.successor.HandleRequest(model);
            }
            else
            {
                Console.WriteLine("没有后续处理或者暂时不支持这样的功能处理");
                return false;
            }
        }

        protected object LocalHandleRequest(RequestModel model,string roleName) {
            string requestModelType = model.GetModelType();

            //表示聚餐费用申请
            string classFullName = $"CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter.{roleName}{requestModelType}Strategy";
            object strategyObject = ReflectHelper.CreateInstance(classFullName);

            if (strategyObject == null)
            {
                //其它未定义的事由，项目经理暂时不想处理
                return this.HandleRequest(model);
            }
            else
            {
                ILocalHandleStrategy strategy = (ILocalHandleStrategy)strategyObject;
                return strategy.LocalHandle(model, this);
            }
        }
    }

}

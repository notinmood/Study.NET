/**
 * @file   : ProjectManager.cs
 * @date   : 2024/7/9 15:35:04
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using CoreConsoleApp.反射研究;

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter
{
    /**
 * 实现项目经理处理聚餐费用申请的对象
 */
    public class ProjectManager : Handler
    {
        public override object HandleRequest(RequestModel model)
        {
            return LocalHandleRequest(model,"Project");

            //string requestModelType = model.GetType();

            ////表示聚餐费用申请
            //string classFullName = $"CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter.Project{requestModelType}Strategy";
            //object strategyObject = ReflectHelper.CreateInstance(classFullName);

            //if (strategyObject == null)
            //{
            //    //其它未定义的事由，项目经理暂时不想处理
            //    return base.HandleRequest(model);
            //}
            //else
            //{
            //    ILocalHandleStrategy strategy = (ILocalHandleStrategy)strategyObject;
            //    return strategy.LocalHandle(model, this);
            //}
        }
        
    }

}

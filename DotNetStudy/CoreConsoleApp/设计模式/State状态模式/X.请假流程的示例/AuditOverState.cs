

using System;

/**
 * @file   : AuditOverState.cs
 * @date   : 2024/7/7 10:25:07
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.State状态模式.X.请假流程的示例
{
    /**
     * 处理审核结束的类
     */
    public class AuditOverState : ILeaveRequestState
    {
        public void doWork(StateMachine request)
        {
            //先把业务对象造型回来
            LeaveRequestModel lrm = (LeaveRequestModel)request.getBusinessVO();

            //业务处理，在数据里面记录整个流程结束   
            Console.WriteLine(lrm.getUser() + "，你的请假申请已经审核结束，结果是：" + lrm.getResult());
        }
    }
}

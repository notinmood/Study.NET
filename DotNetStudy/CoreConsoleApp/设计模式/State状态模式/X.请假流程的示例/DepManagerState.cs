﻿/**
 * @file   : DepManagerState.cs
 * @date   : 2024/7/7 10:24:33
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.X.请假流程的示例
{

    /**
     * 处理部门经理的审核，处理后对应审核结束状态
     */
    public class DepManagerState : ILeaveRequestState
    {
        public void DoWork(StateMachine ctx)
        {
            //先把业务对象造型回来
            LeaveRequestModel lrm = (LeaveRequestModel)ctx.GetBusinessVO();
            Console.WriteLine("部门经理审核中，请稍候......");
            //模拟用户处理界面，通过控制台来读取数据
            Console.WriteLine(lrm.GetUser() + "申请从" + lrm.GetBeginDate() + "开始请假" + lrm.GetLeaveDays() + "天,请部门经理审核(1为同意，2为不同意)：");
            //读取从控制台输入的数据
            string userInput = Console.ReadLine();

            //设置回到上下文中
            String result = "不同意";
            if (userInput == "1")
            {
                result = "同意";
            }

            lrm.SetResult("部门经理审核结果：" + result);
            //部门经理审核过后，直接转向审核结束状态了
            ctx.SetState(new AuditOverState());
            //继续执行下一步工作
            ctx.DoWork();
        }
    }
}

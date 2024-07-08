

using System;

/**
 * @file   : ProjectManagerState.cs
 * @date   : 2024/7/7 10:23:18
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.设计模式.State状态模式.X.请假流程的示例
{

    /**
     * 处理项目经理的审核，处理后可能对应部门经理审核、审核结束之中的一种
     */
    public class ProjectManagerState : ILeaveRequestState
    {
        public void doWork(StateMachine request)
        {
            //先把业务对象造型回来
            LeaveRequestModel lrm = (LeaveRequestModel)request.getBusinessVO();
            Console.WriteLine("项目经理审核中，请稍候......");
            //模拟用户处理界面，通过控制台来读取数据
            Console.WriteLine(lrm.getUser() + "申请从" + lrm.getBeginDate() + "开始请假" + lrm.getLeaveDays() + "天,请项目经理审核(1为同意，2为不同意)：");
            //读取从控制台输入的数据
            string userInput = Console.ReadLine();

            string result = "不同意";
            if (userInput == "1")
            {
                result = "同意";
            }
            lrm.setResult("项目经理审核结果：" + result);

            //根据选择的结果和条件来设置下一步
            if (userInput == "1")
            {
                if (lrm.getLeaveDays() > 3)
                {
                    //如果请假天数大于3天，而且项目经理同意了，
                    //就提交给部门经理
                    request.setState(new DepManagerState());
                    //继续执行下一步工作
                    request.doWork();
                }
                else
                {
                    //3天以内的请假，由项目经理做主,就不用提交给部门经理了，
                    //转向审核结束状态
                    request.setState(new AuditOverState());
                    //继续执行下一步工作
                    request.doWork();
                }
            }
            else
            {
                //项目经理不同意，就不用提交给部门经理了，转向审核结束状态
                request.setState(new AuditOverState());
                //继续执行下一步工作
                request.doWork();
            }

        }
    }
}
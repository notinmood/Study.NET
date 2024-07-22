/**
 * @file   : Client.cs
 * @date   : 2024/7/7 10:41:25
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.State状态模式.X.请假流程的示例
{
    public static class Client
    {
        public static void Index()
        {
            //创建业务对象，并设置业务数据
            LeaveRequestModel lrm = new LeaveRequestModel();
            lrm.setUser("小李");
            lrm.SetBeginDate("2010-02-08");
            lrm.SetLeaveDays(5);

            //创建上下文对象
            LeaveRequestContext request = new LeaveRequestContext();
            //为上下文对象设置业务数据对象
            request.SetBusinessVO(lrm);
            //配置上下文，作为开始的状态，以后就不管了
            request.SetState(new ProjectManagerState());

            //请求上下文，让上下文开始处理工作
            request.DoWork();
        }
    }

}

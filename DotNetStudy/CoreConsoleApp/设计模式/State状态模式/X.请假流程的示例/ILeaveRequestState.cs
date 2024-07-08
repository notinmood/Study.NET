/**
 * @file   : LeaveRequestState.cs
 * @date   : 2024/7/7 10:22:18
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.State状态模式.X.请假流程的示例
{
    public interface ILeaveRequestState : IState
    {
        //这里可以扩展跟自己流程相关的处理
    }

}

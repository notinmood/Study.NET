/**
 * @file   : StateMachine.cs
 * @date   : 2024/7/7 10:19:40
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.X.请假流程的示例
{
    /**
 * 公共状态处理机，相当于状态模式的Context
 * 包含所有流程使用状态模式时的公共功能
 */
    public class StateMachine
    {
        /**
         * 持有一个状态对象
         */
        private IState state = null;

        /**
         * 包含流程处理需要的业务数据对象，不知道具体类型,为了简单，不去使用泛型，
         * 用Object，反正只是传递到具体的状态对象里面
         */
        private Object businessVO = null;
        /**
         * 执行工作，客户端处理流程的接口方法。
         * 在客户完成自己的业务工作后调用
         */
        public void doWork()
        {
            //转调相应的状态对象真正完成功能处理
            this.state.doWork(this);
        }

        public IState getState()
        {
            return state;
        }
        public void setState(IState state)
        {
            this.state = state;
        }
        public Object getBusinessVO()
        {
            return businessVO;
        }
        public void setBusinessVO(Object businessVO)
        {
            this.businessVO = businessVO;
        }
    }

}

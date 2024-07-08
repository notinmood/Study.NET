/**
 * @file   : State.cs
 * @date   : 2024/7/7 10:20:32
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.State状态模式.X.请假流程的示例
{
    /**
  * 公共状态接口
  */
    public interface IState
    {
        /**
         * 执行状态对应的功能处理
         * @param ctx 上下文的实例对象
         */
        public void doWork(StateMachine ctx);
    }

}

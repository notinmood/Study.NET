/**
 * @file   : FlowAMementoCareTaker.cs
 * @date   : 2024/7/17 10:04:15
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Memento备忘录模式.UsePattern
{
    /**
 * 负责保存模拟运行流程A的对象的备忘录对象
 */
    public class WorkFlowMementoCareTaker
    {
        /**
         * 记录被保存的备忘录对象
         */
        private IWorkFlowMockMemento memento = null;
        /**
         * 保存备忘录对象
         * @param memento 被保存的备忘录对象
         */
        public void SaveMemento(IWorkFlowMockMemento memento)
        {
            this.memento = memento;
        }
        /**
         * 获取被保存的备忘录对象
         * @return 被保存的备忘录对象
         */
        public IWorkFlowMockMemento RetriveMemento()
        {
            return this.memento;
        }
    }

}

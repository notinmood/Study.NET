/**
 * @file   : FlowAMock.cs
 * @date   : 2024/7/17 10:03:36
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Memento备忘录模式.UsePattern
{
    /**
 * 模拟运行流程A，只是一个示意，代指某个具体流程
 */
    public class WorkFlowMock
    {
        /**
         * 流程名称，不需要外部存储的状态数据
         */
        private string flowName;
        /**
         * 示意，代指某个中间结果，需要外部存储的状态数据
         */
        private int tempResult;
        /**
         * 示意，代指某个中间结果，需要外部存储的状态数据
         */
        private string tempState;
        /**
         * 构造方法，传入流程名称
         * @param flowName 流程名称
         */
        public WorkFlowMock(string flowName)
        {
            this.flowName = flowName;
        }
        /**
         * 示意，运行流程的第一个阶段
         */
        public void RunPhaseOne()
        {
            //在这个阶段，可能产生了中间结果，示意一下
            this.tempResult = 3;
            this.tempState = "PhaseOne";
        }
        /**
         * 示意，按照方案一来运行流程后半部分
         */
        public void RunPhaseTwoSchema1()
        {
            //示意，需要使用第一个阶段产生的数据
            this.tempState += ",Schema1";
            Console.WriteLine(this.tempState + " : now run " + tempResult);
            this.tempResult += 11;
        }
        /**
         * 示意，按照方案二来运行流程后半部分
         */
        public void RunPhaseTwoSchema2()
        {
            //示意，需要使用第一个阶段产生的数据
            this.tempState += ",Schema2";
            Console.WriteLine(this.tempState + " : now run " + tempResult);
            this.tempResult += 22;
        }
        /**
         * 创建保存原发器对象的状态的备忘录对象
         * @return 创建好的备忘录对象
         */
        public IWorkFlowMockMemento CreateMemento()
        {
            return new MementoImpl(this.tempResult, this.tempState);
        }
        /**
         * 重新设置原发器对象的状态，让其回到备忘录对象记录的状态
         * @param memento 记录有原发器状态的备忘录对象
         */
        public void SetMemento(IWorkFlowMockMemento memento)
        {
            //特别注意：memento对象的类型虽然目前是空接口IWorkFlowMockMemento，
            //  从当前类型下，使用memento是无法获悉内部属性的。
            //  但是，可以将对象memento，强制转换为类型MementoImpl，
            //  因为当初放入的就是这个类型的对象实例。
            MementoImpl mementoImpl = (MementoImpl)memento;
            this.tempResult = mementoImpl.GetTempResult();
            this.tempState = mementoImpl.GetTempState();
        }
        /**
         * 真正的备忘录对象，实现备忘录窄接口
         * 实现成私有的内部类，不让外部访问
         */
        private class MementoImpl : IWorkFlowMockMemento
        {
            /**
             * 示意，保存某个中间结果
             */
            private int tempResult;
            /**
             * 示意，保存某个中间结果
             */
            private string tempState;
            public MementoImpl(int tempResult, string tempState)
            {
                this.tempResult = tempResult;
                this.tempState = tempState;
            }
            public int GetTempResult()
            {
                return tempResult;
            }
            public string GetTempState()
            {
                return tempState;
            }
        }
    }

}

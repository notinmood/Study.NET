/**
 * @file   : Client.cs
 * @date   : 2024/7/17 10:10:07
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Memento备忘录模式.UsePattern
{
    public class Client
    {
        public static void main(String[] args)
        {
            // 创建模拟运行流程的对象
            WorkFlowMock mock = new WorkFlowMock("TestFlow");
            //运行流程的第一个阶段
            mock.RunPhaseOne();
            //创建一个管理者
            WorkFlowMementoCareTaker careTaker = new WorkFlowMementoCareTaker();
            //创建此时对象的备忘录对象，并保存到管理者对象那里，后面要用
            IWorkFlowMockMemento memento = mock.CreateMemento();
            careTaker.SaveMemento(memento);

            //按照方案一来运行流程后半部分
            mock.RunPhaseTwoSchema1();

            //从管理者获取备忘录对象，然后设置回去，
            //让模拟运行流程的对象自己恢复自己的内部状态
            mock.SetMemento(careTaker.RetriveMemento());

            //按照方案二来运行流程后半部分
            mock.RunPhaseTwoSchema2();
        }
    }

}

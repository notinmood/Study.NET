﻿/**
 * @file   : Client.cs
 * @date   : 2024/7/17 8:16:06
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Memento备忘录模式.NoPattern
{
    public class Client
    {
        public static void Index()
        {
            // 创建模拟运行流程的对象
            FlowAMock mock = new FlowAMock("TestFlow");
            //运行流程的第一个阶段
            mock.runPhaseOne();
            //得到第一个阶段运行所产生的数据，后面要用
            int tempResult = mock.getTempResult();
            String tempState = mock.getTempState();

            //按照方案一来运行流程后半部分
            mock.schema1();

            //把第一个阶段运行所产生的数据重新设置回去
            mock.setTempResult(tempResult);
            mock.setTempState(tempState);

            //按照方案二来运行流程后半部分
            mock.schema2();
        }
    }

}

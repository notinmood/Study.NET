﻿using System;

namespace CoreConsoleApp.设计模式.Facade外观模式.Biz
{
    /**
   * 示意生成逻辑层的模块
   */
    public class Business
    {
        public void generate()
        {
            ConfigModel cm = ConfigManager.getInstance().getConfigData();
            if (cm.isNeedGenBusiness())
            {
                Console.WriteLine("正在生成逻辑层代码文件");
            }
        }
    }
}

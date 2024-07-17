using System;

namespace CoreConsoleApp.设计模式.Facade外观模式.Biz
{
    /**
   * 示意生成表现层的模块
   */
    public class Presentation
    {
        public void Generate()
        {
            //1：从配置管理里面获取相应的配置信息
            ConfigModel cm = ConfigManager.GetInstance().GetConfigData();
            if (cm.IsNeedGenPresentation())
            {
                //2：按照要求去生成相应的代码，并保存成文件
                Console.WriteLine("正在生成表现层代码文件");
            }
        }
    }
}

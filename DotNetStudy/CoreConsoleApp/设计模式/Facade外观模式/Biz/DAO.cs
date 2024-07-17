using System;

namespace CoreConsoleApp.设计模式.Facade外观模式.Biz
{
    /**
   * 示意生成数据层的模块
   */
    public class DAO
    {
        public void Generate()
        {
            ConfigModel cm = ConfigManager.GetInstance().GetConfigData();
            if (cm.IsNeedGenDAO())
            {
                Console.WriteLine("正在生成数据层代码文件");
            }
        }
    }
}

namespace CoreConsoleApp.设计模式.Facade外观模式.Biz
{
    /**
   * 示意配置管理，就是负责读取配置文件，
   * 并把配置文件的内容设置到配置Model中去，是个单例
   */
    public class ConfigManager
    {
        private static ConfigManager instance = null;
        private static ConfigModel cm = null;
        private ConfigManager()
        {
            //
        }
        public static ConfigManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ConfigManager();
                cm = new ConfigModel();
                //读取配置文件，把值设置到ConfigModel中去，这里省略了
            }
            return instance;
        }
        /**
         * 获取配置的数据
         * @return 配置的数据
         */
        public ConfigModel GetConfigData()
        {
            return cm;
        }
    }

}

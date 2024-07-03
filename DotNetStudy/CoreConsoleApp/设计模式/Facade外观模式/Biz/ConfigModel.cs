namespace CoreConsoleApp.设计模式.Facade外观模式.Biz
{
    /**
   * 示意配置描述的数据Model，真实的配置数据会很多
   */
    public class ConfigModel
    {
        /**
         * 是否需要生成表现层，默认是true
         */
        private bool needGenPresentation = true;

        /**
         * 是否需要生成逻辑层，默认是true
         */
        private bool needGenBusiness = true;

        /**
         * 是否需要生成DAO，默认是true
         */
        private bool needGenDAO = true;

        public bool isNeedGenPresentation()
        {
            return needGenPresentation;
        }
        public void setNeedGenPresentation(bool needGenPresentation)
        {
            this.needGenPresentation = needGenPresentation;
        }

        public bool isNeedGenBusiness()
        {
            return needGenBusiness;
        }
        public void setNeedGenBusiness(bool needGenBusiness)
        {
            this.needGenBusiness = needGenBusiness;
        }

        public bool isNeedGenDAO()
        {
            return needGenDAO;
        }
        public void setNeedGenDAO(bool needGenDAO)
        {
            this.needGenDAO = needGenDAO;
        }
    }
}
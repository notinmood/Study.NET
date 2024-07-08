using System;

namespace CoreConsoleApp.设计模式.Builder构造器模式.场景1.Biz
{
    /**
   * 描述输出到文件尾的内容的对象
   */
    public class FooterModel
    {
        /**
         * 输出人
         */
        private string exportUser;
        public string getExportUser()
        {
            return exportUser;
        }
        public void setExportUser(string exportUser)
        {
            this.exportUser = exportUser;
        }
    }
}

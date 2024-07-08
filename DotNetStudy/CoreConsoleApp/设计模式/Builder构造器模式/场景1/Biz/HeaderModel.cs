using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.Builder构造器模式.场景1.Biz
{
    /**
   * 描述输出到文件头的内容的对象
   */
    public class HeaderModel
    {
        /**
         * 分公司或门市点编号
         */
        private string depId;
        /**
         * 导出数据的日期
         */
        private string exportDate;
        public string getDepId()
        {
            return depId;
        }
        public void setDepId(string depId)
        {
            this.depId = depId;
        }
        public string getExportDate()
        {
            return exportDate;
        }
        public void setExportDate(string exportDate)
        {
            this.exportDate = exportDate;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CoreConsoleApp.设计模式.Builder构造器模式.场景1.Biz;

namespace CoreConsoleApp.设计模式.Builder构造器模式.场景1.NoPattern
{
    /**
     * 导出数据到文本文件的对象
     */
    public class TextExporter
    {
        /**
         * 导出数据到文本文件
         * @param ehm 文件头的内容
         * @param mapData 数据的内容
         * @param efm 文件尾的内容
         */
        public void export(HeaderModel ehm, Dictionary<string, Collection<DataModel>> mapData, FooterModel efm)
        {
            //用来记录最终输出的文件内容
            StringBuilder buffer = new StringBuilder();
            //1：先来拼接文件头的内容
            buffer.Append(ehm.getDepId() + "," + ehm.getExportDate() + "\n");
            //2：接着来拼接文件体的内容
            foreach (string tblName in mapData.Keys)
            {
                //先拼接表名称
                buffer.Append(tblName + "\n");
                //然后循环拼接具体数据
                foreach (DataModel edm in mapData[tblName])
                {
                    buffer.Append(edm.getProductId() + "," + edm.getPrice() + "," + edm.getAmount() + "\n");
                }
            }
            //3：接着来拼接文件尾的内容
            buffer.Append(efm.getExportUser());

            //为了演示简洁性，这里就不去写输出文件的代码了
            //把要输出的内容输出到控制台看看
            Console.WriteLine("输出到文本文件的内容：\n" + buffer);
        }
    }
}

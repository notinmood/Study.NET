using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CoreConsoleApp.设计模式.Builder构造器模式.Biz;

namespace CoreConsoleApp.设计模式.Builder构造器模式.NoPattern
{
    /**
     * 导出数据到XML文件的对象
     */
    public class XmlExporter
    {
        /**
         * 导出数据到XML文件
         * @param ehm 文件头的内容
         * @param mapData 数据的内容
         * @param efm 文件尾的内容
         */
        public void export(ExportHeaderModel ehm, Dictionary<string, Collection<ExportDataModel>> mapData, ExportFooterModel efm)
        {
            //用来记录最终输出的文件内容
            StringBuilder buffer = new StringBuilder();
            //1：先来拼接文件头的内容
            buffer.Append("<?xml version='1.0' encoding='gb2312'?>\n");
            buffer.Append("<Report>\n");
            buffer.Append("  <Header>\n");
            buffer.Append("    <DepId>" + ehm.getDepId() + "</DepId>\n");
            buffer.Append("    <ExportDate>" + ehm.getExportDate() + "</ExportDate>\n");
            buffer.Append("  </Header>\n");
            //2：接着来拼接文件体的内容
            buffer.Append("  <Body>\n");
            foreach (String tblName in mapData.Keys)
            {
                //先拼接表名称
                buffer.Append("    <Datas TableName=\"" + tblName + "\">\n");
                //然后循环拼接具体数据
                foreach (ExportDataModel edm in mapData[tblName])
                {
                    buffer.Append("      <Data>\n");
                    buffer.Append("          <ProductId>" + edm.getProductId() + "</ProductId>\n");
                    buffer.Append("          <Price>" + edm.getPrice() + "</Price>\n");
                    buffer.Append("          <Amount>" + edm.getAmount() + "</Amount>\n");
                    buffer.Append("      </Data>\n");
                }
                buffer.Append("    </Datas>\n");
            }
            buffer.Append("  </Body>\n");
            //3：接着来拼接文件尾的内容
            buffer.Append("  <Footer>\n");
            buffer.Append("    <ExportUser>" + efm.getExportUser() + "</ExportUser>\n");
            buffer.Append("  </Footer>\n");
            buffer.Append("</Report>\n");

            //为了演示简洁性，这里就不去写输出文件的代码了
            //把要输出的内容输出到控制台看看
            Console.WriteLine("输出到XML文件的内容：\n" + buffer);
        }
    }

}

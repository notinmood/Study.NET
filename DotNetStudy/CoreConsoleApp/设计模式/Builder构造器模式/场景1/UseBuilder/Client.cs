using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoreConsoleApp.设计模式.Builder构造器模式.场景1.Biz;

namespace CoreConsoleApp.设计模式.Builder构造器模式.场景1.UseBuilder
{
    public class Client
    {
        public static void Index()
        {
            //准备测试数据
            HeaderModel ehm = new HeaderModel();
            ehm.setDepId("一分公司");
            ehm.setExportDate("2010-05-18");

            Dictionary<string, Collection<DataModel>> mapData = [];
            Collection<DataModel> col = [];

            DataModel edm1 = new DataModel();
            edm1.setProductId("产品001号");
            edm1.setPrice(100);
            edm1.setAmount(80);

            DataModel edm2 = new DataModel();
            edm2.setProductId("产品002号");
            edm2.setPrice(99);
            edm2.setAmount(55);
            //把数据组装起来
            col.Add(edm1);
            col.Add(edm2);
            mapData.Add("销售记录表", col);

            FooterModel efm = new FooterModel();
            efm.setExportUser("张三");

            //测试输出到文本文件
            TxtBuilder txtBuilder = new TxtBuilder();
            //创建指导者对象
            Director director = new Director(txtBuilder);
            director.construct(ehm, mapData, efm);
            //把要输出的内容输出到控制台看看
            Console.WriteLine("输出到文本文件的内容：\n" + txtBuilder.getResult());
            //测试输出到xml文件
            XmlBuilder xmlBuilder = new XmlBuilder();
            Director director2 = new Director(xmlBuilder);
            director2.construct(ehm, mapData, efm);
            //把要输出的内容输出到控制台看看
            Console.WriteLine("输出到XML文件的内容：\n" + xmlBuilder.getResult());
        }
    }
}

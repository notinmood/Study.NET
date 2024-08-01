/**
 * @file   : Client.cs
 * @date   : 2024/8/1 15:44:30
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.UsePattern
{
    public static class Client
    {
        public static void main(String[] args)
        {
            //创建ObjectStructure
            ObjectStructure os = new ObjectStructure();
            //准备点测试数据，创建客户对象，并加入ObjectStructure
            Customer cm1 = new EnterpriseCustomer();
            cm1.SetName("ABC集团");
            os.AddElement(cm1);

            Customer cm2 = new EnterpriseCustomer();
            cm2.SetName("CDE公司");
            os.AddElement(cm2);

            Customer cm3 = new PersonalCustomer();
            cm3.SetName("张三");
            os.AddElement(cm3);

            //客户提出服务请求，传入服务请求的Visitor
            ServiceRequestVisitor srVisitor = new ServiceRequestVisitor();
            os.HandleRequest(srVisitor);

            //要对客户进行偏好分析，传入偏好分析的Visitor
            PredilectionAnalyzeVisitor paVisitor = new PredilectionAnalyzeVisitor();
            os.HandleRequest(paVisitor);
        }
    }

}

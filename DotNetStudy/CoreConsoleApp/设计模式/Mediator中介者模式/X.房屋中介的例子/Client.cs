/**
 * @file   : Client.cs
 * @date   : 2024/7/25 14:25:06
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.Mediator中介者模式.X.房屋中介的例子
{
    //测试类
    public static class Client
    {
        public static void Index()
        {
            //一个房主、一个租房者、一个中介机构
            MediatorStructure mediator = new MediatorStructure();
            
            //房主和租房者只需要知道中介机构即可
            HouseOwner houseOwner = new HouseOwner("张三", mediator);
            Tenant tenant = new Tenant("李四", mediator);
            
            //中介结构要知道房主和租房者
            mediator.SetHouseOwner(houseOwner);
            mediator.SetTenant(tenant);
            tenant.Constact("需要租三室的房子");
            houseOwner.Constact("我这有三室的房子，你需要租吗？");
        }
    }

}

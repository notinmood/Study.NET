/**
 * @file   : MediatorStructure.cs
 * @date   : 2024/7/25 14:24:20
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Mediator中介者模式.X.房屋中介的例子
{
    //中介机构
    public class MediatorStructure : IMediator
    {
        //首先中介结构必须知道所有房主和租房者的信息
        private HouseOwner houseOwner;
        private Tenant tenant;

        public HouseOwner GetHouseOwner()
        {
            return houseOwner;
        }
        public void SetHouseOwner(HouseOwner houseOwner)
        {
            this.houseOwner = houseOwner;
        }
        public Tenant GetTenant()
        {
            return tenant;
        }
        public void SetTenant(Tenant tenant)
        {
            this.tenant = tenant;
        }
        public void Constact(string message, Person person)
        {
            if (person == houseOwner)
            {
                //如果是房主，则租房者获得信息
                tenant.GetMessage(message);
            }
            else
            {
                //反之则是房主获得信息
                houseOwner.GetMessage(message);
            }
        }
    }
}

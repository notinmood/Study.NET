/**
 * @file   : Proxy.cs
 * @date   : 2024/7/28 9:36:36
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Linq;
using CoreConsoleApp.设计模式.Proxy代理模式.Biz;

namespace CoreConsoleApp.设计模式.Proxy代理模式.UsePattern
{
    /**
   * 代理对象,代理用户数据对象
   */
    public class Proxy : IUserModel
    {
        /**
         * 持有被代理的具体的目标对象
         */
        private readonly UserModel realSubject = null;

        /**
         * 构造方法，传入被代理的具体的目标对象
         * @param realSubject 被代理的具体的目标对象
         */
        public Proxy(UserModel realSubject)
        {
            this.realSubject = realSubject;
        }

        /**
         * 标示是否已经重新装载过数据了
         */
        private bool loaded = false;

        public string GetUserId()
        {
            return realSubject.GetUserId();
        }
        public void SetUserId(string userId)
        {
            realSubject.SetUserId(userId);
        }
        public string GetName()
        {
            return realSubject.GetName();
        }
        public void SetName(string name)
        {
            realSubject.SetName(name);
        }
        public void SetDepId(string depId)
        {
            realSubject.SetDepId(depId);
        }
        public void SetSex(string sex)
        {
            realSubject.SetSex(sex);
        }
        public string GetDepId()
        {
            return realSubject.GetDepId();
        }

        public string GetSex()
        {
            return realSubject.GetSex();
        }


        public string GetDepName()
        {
            //需要判断是否已经装载过了
            if (!this.loaded)
            {
                //从数据库中重新装载
                reload();
                //设置重新装载的标志为true
                this.loaded = true;
            }
            return realSubject.GetDepName();
        }


        public string GetDepDesc()
        {
            //需要判断是否已经装载过了
            if (!this.loaded)
            {
                //从数据库中重新装载
                reload();
                //设置重新装载的标志为true
                this.loaded = true;
            }
            return realSubject.GetDepDesc();
        }


        /**
         * 重新查询数据库以获取完整的用户数据
         */
        private void reload()
        {
            Console.WriteLine($"重新查询数据库获取完整的用户数据,userId={realSubject.GetUserId()}");
            var result = Db.UsersInDB.Where(s => s.GetUserId() == this.GetUserId()).Join(Db.DepsInDB, o => o.GetDepId(), i => i.DepId, (o, i) => new { i.DepName, i.DepDesc }).FirstOrDefault();

            if (result != null)
            {
                this.realSubject.SetDepName(result.DepName);
                this.realSubject.SetDepDesc(result.DepDesc);
            }
        }
        public override string ToString()
        {
            return "userId=" + GetUserId() + ",name=" + GetName() + ",depId=" + GetDepId() + ",sex=" + GetSex();
        }
    }
}

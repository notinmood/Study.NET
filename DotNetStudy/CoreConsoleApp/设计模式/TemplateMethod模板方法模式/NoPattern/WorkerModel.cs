/**
 * @file   : WorkerModel.cs
 * @date   : 2024/7/12 7:19:48
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.TemplateMethod模板方法模式.NoPattern
{
    /**
 * 描述工作人员信息的数据模型
 */
    public class WorkerModel
    {
        private string uuid, workerId, pwd, name;
        public string GetUuid()
        {
            return uuid;
        }
        public void SetUuid(string uuid)
        {
            this.uuid = uuid;
        }
        public string GetWorkerId()
        {
            return workerId;
        }
        public void SetWorkerId(string workerId)
        {
            this.workerId = workerId;
        }
        public string GetPwd()
        {
            return pwd;
        }
        public void SetPwd(string pwd)
        {
            this.pwd = pwd;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
    }

}

/**
 * @file   : WorkerLoginModel.cs
 * @date   : 2024/7/12 7:18:48
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
 * 描述登录人员登录时填写的信息的数据模型
 */
    public class WorkerLoginModel
    {
        private string workerId, pwd;
        public string getWorkerId()
        {
            return workerId;
        }
        public void setWorkerId(string workerId)
        {
            this.workerId = workerId;
        }
        public string getPwd()
        {
            return pwd;
        }
        public void setPwd(string pwd)
        {
            this.pwd = pwd;
        }
    }

}

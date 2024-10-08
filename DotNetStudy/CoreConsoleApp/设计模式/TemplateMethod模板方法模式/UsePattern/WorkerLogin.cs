﻿/**
 * @file   : WorkerLogin.cs
 * @date   : 2024/7/12 8:20:14
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.TemplateMethod模板方法模式.UsePattern
{
    /**
 * 工作人员登录控制的逻辑处理
 */
    public class WorkerLogin : LoginTemplate
    {
        public override LoginModel FindLoginUser(string loginId)
        {
            // 这里省略具体的处理，仅做示意，返回一个有默认数据的对象
            LoginModel lm = new LoginModel();
            lm.SetLoginId(loginId);
            lm.SetPwd("workerpwd");
            return lm;
        }

        public override string EncryptPwd(string pwd)
        {
            //覆盖父类的方法，提供真正的加密实现
            //这里对密码进行加密，比如使用：MD5、3DES等等，省略了
            Console.WriteLine("使用MD5进行密码加密");
            return pwd;
        }
    }

}

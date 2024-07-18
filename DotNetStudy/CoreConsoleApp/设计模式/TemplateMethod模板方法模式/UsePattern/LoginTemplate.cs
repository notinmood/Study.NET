﻿/**
 * @file   : LoginTemplate.cs
 * @date   : 2024/7/12 7:54:41
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.TemplateMethod模板方法模式.UsePattern
{
    /**
 *  登录控制的模板
 */
    public abstract class LoginTemplate
    {
        /**
         * 判断登录数据是否正确，也就是是否能登录成功
         * @param lm 封装登录数据的Model
         * @return true表示登录成功，false表示登录失败
         */
        public bool Login(LoginModel lm)
        {
            //1：根据登录人员的编号去获取相应的数据
            LoginModel dbLm = this.FindLoginUser(lm.GetLoginId());
            if (dbLm != null)
            {
                //2：对密码进行加密
                string encryptPwd = this.EncryptPwd(lm.GetPwd());
                //把加密后的密码设置回到登录数据模型里面
                lm.SetPwd(encryptPwd);
                //3：判断是否匹配
                return this.Match(lm, dbLm);
            }
            return false;
        }
        
        /**
         * 根据登录编号来查找和获取存储中相应的数据
         * @param loginId 登录编号
         * @return 登录编号在存储中相对应的数据
         */
        public abstract LoginModel FindLoginUser(string loginId);
        
        /**
         * 对密码数据进行加密
         * @param pwd 密码数据
         * @return 加密后的密码数据
         */
        public virtual string EncryptPwd(string pwd)
        {
            return pwd;
        }
        
        /**
         * 判断用户填写的登录数据和存储中对应的数据是否匹配得上
         * @param lm 用户填写的登录数据
         * @param dbLm 在存储中对应的数据
         * @return true表示匹配成功，false表示匹配失败
         */
        public bool Match(LoginModel lm, LoginModel dbLm)
        {
            if (lm.GetLoginId() == (dbLm.GetLoginId()) && lm.GetPwd() == (dbLm.GetPwd()))
            {
                return true;
            }
            return false;
        }
    }

}

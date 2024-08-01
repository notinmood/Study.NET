/**
 * @file   : User.cs
 * @date   : 2024/7/25 11:08:54
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Mediator中介者模式.X.部门人员关系的处理
{
    /**
 * 人员类
 */
    public class User
    {
        /**
         * 人员编号
         */
        private string userId;
        /**
         * 人员名称
         */
        private string userName;

        public string getUserId()
        {
            return userId;
        }
        public void setUserId(string userId)
        {
            this.userId = userId;
        }
        public string getUserName()
        {
            return userName;
        }
        public void setUserName(string userName)
        {
            this.userName = userName;
        }
        /**
         * 人员离职
         * @return 是否处理成功
         */
        public bool dimission()
        {
            //1：要先通过中介者去清除掉所有与这个人员相关的部门和人员的关系
            DepUserMediatorImpl mediator = DepUserMediatorImpl.getInstance();
            mediator.DeleteUser(userId);
            //2：然后才能真的清除掉这个人员
            //请注意，实际开发中，人员离职，是不会真的删除人员记录的，
            //通常是把人员记录的状态或者是删除标记设置成已删除，
            //只是不再参加新的业务，但是已经发生的业务记录是不会被清除掉的    

            return true;
        }
    }

}

/**
 * @file   : VoteManager.cs
 * @date   : 2024/7/7 7:13:07
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.State状态模式.NoPattern
{
    /**
 * 投票管理
 */
    public class VoteManager
    {
        /**
         * 记录用户投票的结果,Map<String,String>对应Map<用户名称,投票的选项>
         */
        private Dictionary<string, String> mapVote = new Dictionary<string, String>();
        /**
         * 记录用户投票次数,Map<String,Integer>对应Map<用户名称,投票的次数>
         */
        private Dictionary<string, int> mapVoteCount = new Dictionary<string, int>();
        /**
         * 投票
         * @param user 投票人，为了简单，就是用户名称
         * @param voteItem 投票的选项
         */
        public void vote(string user, string voteItem)
        {
            //1：先为该用户增加投票的次数
            //先从记录中取出已有的投票次数
            if (!mapVoteCount.TryGetValue(user, out int oldVoteCount))
            {
                oldVoteCount = 0;
            }
            oldVoteCount = oldVoteCount + 1;
            mapVoteCount[user] = oldVoteCount;

            //2：判断该用户投票的类型，到底是正常投票、重复投票、恶意投票
            //还是上黑名单，然后根据投票类型来进行相应的操作  
            if (oldVoteCount == 1)
            {
                //正常投票
                //记录到投票记录中
                mapVote.Add(user, voteItem);
                Console.WriteLine("恭喜你投票成功");
            }
            else if (oldVoteCount > 1 && oldVoteCount < 5)
            {
                //重复投票
                //暂时不做处理
                Console.WriteLine("请不要重复投票");
            }
            else if (oldVoteCount >= 5 && oldVoteCount < 8)
            {
                //恶意投票
                //取消用户的投票资格，并取消投票记录
                if (mapVote.TryGetValue(user, out string s))
                {
                    mapVote.Remove(user);
                }
                Console.WriteLine("你有恶意刷票行为，取消投票资格");
            }
            else if (oldVoteCount >= 8)
            {
                //黑名单
                //记入黑名单中，禁止登录系统了
                Console.WriteLine("进入黑名单，将禁止登录和使用本系统");
            }
        }
    }
}
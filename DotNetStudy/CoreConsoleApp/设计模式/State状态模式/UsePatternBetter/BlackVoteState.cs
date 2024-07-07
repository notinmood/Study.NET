/**
 * @file   : BlackVoteState.cs
 * @date   : 2024/7/7 8:04:23
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.UsePatternBetter
{
    public class BlackVoteState : IVoteState
    {
        public void Vote(string user, string voteItem, VoteManager voteManager)
        {
            //黑名单
            //记入黑名单中，禁止登录系统了
            Console.WriteLine("进入黑名单，将禁止登录和使用本系统");
        }
    }
}
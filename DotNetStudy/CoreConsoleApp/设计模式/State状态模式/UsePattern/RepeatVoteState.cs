/**
 * @file   : RepeatVoteState.cs
 * @date   : 2024/7/7 7:56:14
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.UsePattern
{
    public class RepeatVoteState : IVoteState
    {
        public void Vote(string user, string voteItem, VoteManager voteManager)
        {
            //重复投票
            //暂时不做处理
            Console.WriteLine("请不要重复投票");
        }
    }
}

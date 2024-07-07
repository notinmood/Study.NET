/**
 * @file   : SpiteVoteState.cs
 * @date   : 2024/7/7 8:00:04
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.UsePattern
{
    public class SpiteVoteState : IVoteState
    {
        public void Vote(string user, string voteItem, VoteManager voteManager)
        {
            //恶意投票
            //取消用户的投票资格，并取消投票记录
            if (voteManager.MapVote.TryGetValue(user, out string s))
            {
                voteManager.MapVote.Remove(user);
            }
            Console.WriteLine("你有恶意刷票行为，取消投票资格");
        }
    }

}

/**
 * @file   : NormalVoteState.cs
 * @date   : 2024/7/7 7:48:47
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.UsePatternBetter
{
    public class NormalVoteState : IVoteState
    {
        public void Vote(string user, string voteItem, VoteManager voteManager)
        {
            //正常投票
            //记录到投票记录中
            voteManager.MapVote[user] = voteItem;
            Console.WriteLine("恭喜你投票成功");

            //正常投票完成，维护下一个状态，同一个人再投票就重复了
            voteManager.MapState[user] = new RepeatVoteState();
        }
    }
}
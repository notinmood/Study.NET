/**
 * @file   : RepeatVoteState.cs
 * @date   : 2024/7/7 7:56:14
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.UsePatternBetter
{
    public class RepeatVoteState : IVoteState
    {
        public void Vote(string user, string voteItem, VoteManager voteManager)
        {
            //重复投票
            //暂时不做处理
            Console.WriteLine("请不要重复投票");

            //重复投票完成，维护下一个状态，重复投票到5次，就算恶意投票了
            //注意这里是判断大于等于4，因为这里设置的是下一个状态
            //下一个操作次数就是5了，就应该算是恶意投票了
            if (voteManager.getCountVoteed(user) >= 4)
            {
                voteManager.MapState[user] = new SpiteVoteState();
            }
        }
    }
}



using CoreConsoleApp.设计模式.State状态模式.UsePattern;



using System.Net.NetworkInformation;

/**
 * @file   : Context.cs
 * @date   : 2024/7/7 8:54:29
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.State状态模式.UsePatternBetter
{
    internal class Context
    {
        private readonly VoteManager vm;

        /**
         * 持有状态处理对象
         */
        private IVoteState state = null;

        public Context(VoteManager vm)
        {
            this.vm = vm;
        }


        /**
         * 投票
         * @param user 投票人，为了简单，就是用户名称
         * @param voteItem 投票的选项
         */
        public void Vote(string user, string voteItem)
        {
            //1：先为该用户增加投票的次数
            //先从记录中取出已有的投票次数
            int oldVoteCount = vm.getCountVoteed(user);

            oldVoteCount = oldVoteCount + 1;
            vm.MapVoteCount[user] = oldVoteCount;

            //2：判断该用户投票的类型，就相当于是判断对应的状态
            //到底是正常投票、重复投票、恶意投票还是上黑名单的状态
            //2：获取该用户的投票状态
            //如果没有投票状态，说明还没有投过票，就初始化一个正常投票状态
            if (!vm.MapState.TryGetValue(user, out IVoteState state))
            {
                state = new NormalVoteState();
            }

            //然后转调状态对象来进行相应的操作
            state.Vote(user, voteItem, vm);
        }
    }
}

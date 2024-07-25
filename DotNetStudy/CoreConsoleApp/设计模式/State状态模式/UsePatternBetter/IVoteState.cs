/**
 * @file   : VoteState.cs
 * @date   : 2024/7/7 7:48:03
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.State状态模式.UsePatternBetter
{
    /**
     * 封装一个投票状态相关的行为
     */
    public interface IVoteState
    {
        /**
         * 处理状态对应的行为
         * @param user 投票人
         * @param voteItem 投票项
         * @param voteManager 投票上下文，用来在实现状态对应的功能处理的时候，
         *                    可以回调上下文的数据
         */
        public void Vote(string user, string voteItem, VoteManager voteManager);
    }

}

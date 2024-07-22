/**
 * @file   : VoteManager.cs
 * @date   : 2024/7/7 7:49:43
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.State状态模式.UsePattern
{
    /**
     * 投票管理
     */
    public class VoteManager
    {
        /**
         * 记录用户投票的结果,Map<String,String>对应Map<用户名称,投票的选项>
         */
        private readonly Dictionary<string, string> mapVote = new Dictionary<string, string>();
        /**
         * 记录用户投票次数,Map<String,Integer>对应Map<用户名称,投票的次数>
         */
        private readonly Dictionary<string, int> mapVoteCount = new Dictionary<string, int>();
        /**
         * 获取记录用户投票结果的Map
         * @return 记录用户投票结果的Map
         */
        public Dictionary<string, string> MapVote
        {
            get { return mapVote; }
        }

        public Dictionary<string, int> MapVoteCount
        {
            get { return mapVoteCount; }
        }

        public int GetCountVoteed(string user)
        {
            //1：先为该用户增加投票的次数
            //先从记录中取出已有的投票次数
            if (!mapVoteCount.TryGetValue(user, out int oldVoteCount))
            {
                oldVoteCount = 0;
            }

            return oldVoteCount;
        }
    }
}

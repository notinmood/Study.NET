/**
 * @file   : Mario.cs
 * @date   : 2024/7/23 8:32:01
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.State状态模式.X.超级马里奥游戏
{
    public class Mario
    {
        private IStatus marioState;

        public Mario()
        {
            this.marioState = new SmallState(this);
        }

        public void ChangeState(IStatus status)
        {
            this.marioState = status;
        }

        public void HandEvent(Events marioEvent)
        {
            if (marioEvent == Events.MUSHROOM)
            {
                marioState.EatMushroom();
            }
            else if (marioEvent == Events.FIRE_FLOWER)
            {
                marioState.EatFireFlower();
            }
            else if (marioEvent == Events.ENEMY_ATTACK)
            {
                marioState.EnemyAttack();
            }
            else if (marioEvent == Events.FALL_INTO_PIT)
            {
                marioState.FallFit();
            }
        }        
    }
}

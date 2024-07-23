using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.State状态模式.X.超级马里奥游戏
{
    public interface IStatus
    {
        void EatMushroom();
        void EatFireFlower();
        void EnemyAttack();
        void FallFit();
    }
}

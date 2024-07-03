using System;

namespace CoreConsoleApp.设计模式.Factory工厂模式.Biz
{
    internal class Tank : Enemy
    {
        public Tank(int x, int y) : base(x, y)
        {
            //
        }

        public override void Show()
        {
            Console.WriteLine($"坦克绘制在坐标x={x},y={y}");
            Console.WriteLine("坦克正在发起攻击...");
        }
    }
}

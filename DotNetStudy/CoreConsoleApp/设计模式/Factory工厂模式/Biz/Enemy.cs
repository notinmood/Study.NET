namespace CoreConsoleApp.设计模式.Factory工厂模式.Biz
{
    internal abstract class Enemy
    {
        //敌人的坐标
        protected int x;
        protected int y;
        //初始化坐标
        public Enemy(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //抽象方法，在地图上绘制
        public abstract void Show();
    }
}

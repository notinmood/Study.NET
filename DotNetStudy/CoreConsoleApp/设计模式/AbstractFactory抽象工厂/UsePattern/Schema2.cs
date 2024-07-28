using CoreConsoleApp.设计模式.AbstractFactory抽象工厂.Biz;

namespace CoreConsoleApp.设计模式.AbstractFactory抽象工厂.UsePattern
{
    internal class Schema2 : AbstractFactory
    {
        public ICPU createCPUApi()
        {
            return new AMDCPU(939);
        }
        public IMainBoard createMainboardApi()
        {
            return new MsiMainBoard(939);
        }
    }
}
using CoreConsoleApp.设计模式.AbstractFactory抽象工厂.Biz;

namespace CoreConsoleApp.设计模式.AbstractFactory抽象工厂.UsePattern
{
    /// <summary>
    /// CPU和主板是相关的对象，是构建电脑的一系列相关配件，
    /// 这个抽象工厂的具体某个实现就相当于一个装机方案，
    /// 客户选择装机方案的时候，一选就是一套，CPU和主板是确定好的，
    /// 不让客户分开选择，这就避免了出现不匹配的错误。
    /// </summary>
    internal class Schema1 : AbstractFactory
    {
        public ICPU createCPUApi()
        {
            return new IntelCPU(1156);
        }
        public IMainBoard createMainboardApi()
        {
            return new GaMainBoard(1156);
        }
    }
}



namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter
{
    internal interface ILocalHandleStrategy
    {
        public object LocalHandle(RequestModel model,Handler handler);
    }
}

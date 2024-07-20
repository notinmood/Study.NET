using CoreConsoleApp.协变和逆变研究.Biz;

namespace CoreConsoleApp.协变和逆变研究.泛型委托的协变逆变研究
{
    internal static class Client
    {
        public static void Index()
        {
            // +--------------------------------------------------------------------------
            // |::说明·| 1. 使用非泛型委托  
            // +-------------------------------------------------------------------------- 

            

            // +--------------------------------------------------------------------------
            // |::说明·| 2. 使用不带协变逆变功能的泛型委托
            // +--------------------------------------------------------------------------
           

            //══════════════════════════
            // +--------------------------------------------------------------------------
            // |::说明·| 3. 使用带有逆变功能的泛型委托
            // +--------------------------------------------------------------------------

            // 3.A. 以下演示实例化委托
            MyActionIn<B> myActionInB = null;
            MyActionIn<A> myActionInA = new MyActionIn<A>(Utils.DealInput);
            MyActionIn<C> myActionInC = new MyActionIn<C>(Utils.DealInput);

            //3.A.1. 赋值
            myActionInB = myActionInA;
            //3.A.2. 执行
            myActionInB(new B());
            myActionInB(new C());
            //// 以下不成立
            //myActionInB = myActionInC;

            //══════════════════════════
            // +--------------------------------------------------------------------------
            // |::说明·| 4. 使用带有协变功能的泛型委托
            // +--------------------------------------------------------------------------
            MyActionOut<B> myActionOutB = null;
            MyActionOut<A> myActionOutA = new(Utils.DealOutput<A>);
            MyActionOut<C> myActionOutC = new(Utils.DealOutput<C>);



            myActionOutB = myActionOutC;
            // 以下赋值会出现编译无法通过问题
            //myActionOutB = myActionOutA;

            B b = myActionOutB();
            A a = myActionOutB();
            //C c = myActionOutB();

            //══════════════════════════
            // +--------------------------------------------------------------------------
            // |::说明·| 5. 使用带有协变和逆变功能的泛型委托
            // +--------------------------------------------------------------------------
            MyActionInOut<B, B> myActionInOutBB = null;
            MyActionInOut<A, A> myActionInOutAA = new(Utils.DealInputOutput<A, A>);
            MyActionInOut<A, C> myActionInOutAC = new(Utils.DealInputOutput<A, C>);
            MyActionInOut<C, C> myActionInOutCC = new(Utils.DealInputOutput<C, C>);
            MyActionInOut<C, A> myActionInOutCA = new(Utils.DealInputOutput<C, A>);


            myActionInOutBB = myActionInOutAC;

            // //以下都无法编译通过
            //myActionInOutBB = myActionInOutAA;
            //myActionInOutBB = myActionInOutCA;
            //myActionInOutBB = myActionInOutCC;


            myActionInOutBB(new C());
            A aa = myActionInOutBB(new C());

            //// 以下类型不兼容，无法编译通过
            //myActionInOutBB(new A());
            //C cc= myActionInOutBB(new C());
        }
    }
}

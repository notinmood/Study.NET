using CoreConsoleApp.协变和逆变研究.RES;

namespace CoreConsoleApp.协变和逆变研究
{
    internal class Client
    {
        public static void index()
        {
            // +--------------------------------------------------------------------------
            // |::说明·| 1. 使用非泛型委托  
            // +-------------------------------------------------------------------------- 
            
            //1.1. 定义委托类型的变量
            //（方法就是委托类型的变量；因为方法的签名有 N 多，因此委托类型也有 N 多；
            //某一种签名的方法，就对应一种类型的委托类型。）
            MyActionNo myFunc = new MyActionNo(Biz.DisplayInformation);
            // |::一一·|  以下两种简写都可以
            //MyActionNo myFunc = new (Biz.DisplayInformation);
            //MyActionNo myFunc = Biz.DisplayInformation;
            
            //1.2. 调用
            myFunc("zhangsan");

            //以下无法编译通过。因为委托是什么类型的参数签名，就要给委托的实例方法传递什么类型的参数。
            //myFunc(123);

            // +--------------------------------------------------------------------------
            // |::说明·| 2. 使用不带协变逆变功能的泛型委托
            // +--------------------------------------------------------------------------
            //MyActionA<string> myActionA = new MyActionCommon<string>(Biz.DisplayInformation);
            MyActionCommon<string> myActionString = new(Biz.DisplayInformation);
            myActionString("qingdao");

            MyActionCommon<object> myActionObject = new(Biz.DealInput);
            myActionObject("qingdao");
            myActionObject(true);


            // 1. 使用未指定协变逆变的委托。其不能将有派生关系的其他类型声明的委托赋给目标类型声明的委托。
            MyActionCommon<B> myActionB = new(Biz.DealInput);

            MyActionCommon<A> myActionA = new(Biz.DealInput);
            MyActionCommon<C> myActionC = new(Biz.DealInput);

            //1.A. 以下演示实例化委托（实例化委托的时候涉及协变和逆变）
            //// 以下赋值都会出现问题。
            //myActionB = myActionC;
            //myActionB = myActionA;
            /** 说明：
             * 委托 MyActionCommon<A>、MyActionCommon<C> 没有从 MyActionCommon<B> 派生，
             * 相反这几个委托对象是同级的，他们从 MyActionCommon<T> 类型派生，后者又派生自object类型。
             * （其中 T 是一个未指定类型的泛型表述；而 A、B、C 是具体定义出的类型。）
             * MyActionCommon<A>、MyActionCommon<C>、MyActionCommon<B>没有相互之间的派生关系，因此赋值兼容性不适用。
             */


            //1.B. 以下演示将泛型类型 T 进行实例化（实例化T的时候不涉及协变逆变）
            myActionB(new B());
            myActionB(new C());
            ////以下无法编译通过
            //myActionB(new A());

            //══════════════════════════
            // +--------------------------------------------------------------------------
            // |::说明·| 3. 使用带有逆变功能的泛型委托
            // +--------------------------------------------------------------------------

            // |::一一·| 3.A. 以下演示实例化委托
            MyActionIn<B> myActionInB = null;
            MyActionIn<A> myActionInA = new MyActionIn<A>(Biz.DealInput);
            MyActionIn<C> myActionInC = new(Biz.DealInput);


            myActionInB = myActionInA;
            //// 以下不成立
            //myActionInB = myActionInC;

            //══════════════════════════
            // +--------------------------------------------------------------------------
            // |::说明·| 4. 使用带有协变功能的泛型委托
            // +--------------------------------------------------------------------------
            MyActionOut<B> myActionOutB = null;
            MyActionOut<A> myActionOutA = new(Biz.DealOutput<A>);
            MyActionOut<C> myActionOutC = new(Biz.DealOutput<C>);



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
            MyActionInOut<A, A> myActionInOutAA = new(Biz.DealInputOutput<A, A>);
            MyActionInOut<A, C> myActionInOutAC = new(Biz.DealInputOutput<A, C>);
            MyActionInOut<C, C> myActionInOutCC = new(Biz.DealInputOutput<C, C>);
            MyActionInOut<C, A> myActionInOutCA = new(Biz.DealInputOutput<C, A>);


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
